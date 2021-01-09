using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Ceiling_App.Model;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Ceiling_App
{
    public partial class MainForm : Form
    {
        private TrainAppOrdersContext db;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            db = new TrainAppOrdersContext();
            LoadClients();
        }

        protected override void OnClosed(EventArgs e)
        {
            db.Dispose();
            base.OnClosed(e);
        }

        public void LoadClients()
        {
            ClientListBox.Items.Clear();
            foreach (Client client in db.Clients)
            {
                ClientListBox.Items.Add(client);
            }
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            ClientForm f2 = new ClientForm();
            Client client = new Client();
            f2.SetClient(client);

            f2.ShowDialog();

            db.Clients.Add(client);
            db.SaveChanges();
            ClientListBox.Items.Add(client);
        }
        public void EditButton_Click(object sender, EventArgs e)
        {
            int clientindex = ClientListBox.SelectedIndex;

            if (clientindex == -1)
            {
                return;
            }

            ClientForm f2 = new ClientForm();
            Client client = (Client)ClientListBox.Items[clientindex];
            f2.SetClient(client);

            f2.ShowDialog();
            if (f2.SaveClient == true)
            { 

            db.SaveChanges();
            ClientListBox.Items[clientindex] = client;
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            while (ClientListBox.SelectedIndices.Count > 0)
            {
                int index = ClientListBox.SelectedIndices[0];
                Client client = (Client)ClientListBox.Items[index];

                db.Clients.Remove(client);
                db.SaveChanges();

                ClientListBox.Items.RemoveAt(index);
            }
        }

        private void ListView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.ForeColor = e.Item.Checked ? Color.Green : Color.Black;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=Krasnoyarsk&APPID=13dfbfddb18aebd886a4d23c97bdf876");

            request.Method = "POST";
            request.ContentType = "aplication/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            response.Close();

            //richTextBox1.Text = answer;

            OpenWeather.OpenWeather oW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);

            panel1.BackgroundImage = oW.weather[0].Icon;

            label2.Text = oW.weather[0].main;
            label3.Text = oW.weather[0].description;

            label4.Text = "Средняя температура (С*): " + oW.main.temp.ToString("0.##");

            label8.Text = "Скорость (м/с): " + oW.wind.speed.ToString();

            label9.Text = "Направление *: " + oW.wind.deg.ToString();

            label5.Text = "Влажность (%): " + oW.main.humidity.ToString();

            label6.Text = "Давление (мм): " + ((int)oW.main.pressure).ToString();
           

        }

        private void ClientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrdersListBox.Items.Clear();
            int index = ClientListBox.SelectedIndex;
            if (index == -1) return;


            Client client = (Client)ClientListBox.Items[index];
            List<Order> orders = client.Orders.ToList();
            foreach (Order order in orders)
            {
                OrdersListBox.Items.Add(order);
            }
        }

        public void AddOrderButton_Click(object sender, EventArgs e)
        {
            int clientIndex = ClientListBox.SelectedIndex;
            if (clientIndex == -1) return;

            Client client = (Client)ClientListBox.Items[clientIndex];

            Order order = new Order { OrderName = "Новый заказ", ClientId = client.ClientId };
            OrderForm f2 = new OrderForm();

            f2.SetOrder(order);

            f2.ShowDialog();
            if (f2.SaveOrder == true)
            {
                db.Orders.Add(order);
                db.SaveChanges();

                OrderTextBox.Text = order.ToDetails();
                OrdersListBox.Items.Add(order);
            }
        }


        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clientindex = ClientListBox.SelectedIndex;
            int orderindex = OrdersListBox.SelectedIndex;
            if (clientindex == -1 || orderindex == -1)
            {

                OrderTextBox.Text = "";
                return;
            }
            Order order = (Order)OrdersListBox.Items[orderindex];
            OrderTextBox.Text = order.ToDetails();
        }

        private void DelOrderButton_Click(object sender, EventArgs e)
        {
            int orderindex = OrdersListBox.SelectedIndex;
            if (orderindex == -1)
            {

                OrderTextBox.Text = "";
                return;
            }
            while (OrdersListBox.SelectedIndices.Count > 0)
            {
                Order order = (Order)OrdersListBox.Items[orderindex];
                db.Orders.Remove(order);
                db.SaveChanges();

                OrdersListBox.Items.RemoveAt(orderindex);
            }
        }
        private void ChangeButtonClick_Click(object sender, EventArgs e)
        {
            int orderindex = OrdersListBox.SelectedIndex;
            if (orderindex == -1)
            {

                OrderTextBox.Text = "";
                return;
            }
            OrderForm f2 = new OrderForm();
              Order order = (Order)OrdersListBox.Items[orderindex];
              f2.SetOrder(order);

              f2.ShowDialog();
              db.SaveChanges();

              OrderTextBox.Text = order.ToString();
              OrdersListBox.Items[orderindex] = order;
              
        }
    }
}
