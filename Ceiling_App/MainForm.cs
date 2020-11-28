using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ceiling_App.Model;

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
            Client client = new Client { FirstName = ClientName.Text, LastName = ClientSName.Text };

            db.Clients.Add(client);
            db.SaveChanges();

            ClientListBox.Items.Add(client);
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

        private void Form1_Load(object sender, EventArgs e)
        {

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
                //  client.Orders.Add(order);
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

            if (f2.SaveOrder == true)
            {
                db.SaveChanges();
            }
            OrderTextBox.Text = order.ToDetails();
            OrdersListBox.Items[orderindex] = order;
        }
    }
}
