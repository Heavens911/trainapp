using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traunappwindow
{
      /*public class OrderContext : DbContext
      { 
      public DbSet<Client> Clients { get; set; }
      public DbSet<Order> Orders { get; set; }
      }*/
    
    public partial class MainFrom : Form
    {
        public List<Clients> Clients = new List<Clients>();
        public List<Orders> Orders = new List<Orders>();

        public MainFrom()
        {
            InitializeComponent();
            
        }
        
        
       
public void AddButton_Click(object sender, EventArgs e)
        {
           Clients client = new Clients { FirstName = ClientName.Text, LastName = ClientSName.Text };
           Clients.Add(client);
          
            using (var db = new Model1Container())
            {
                ClientListBox.Items.Add(client);
                //var order = new Order { OrderName = "заказ" };
                db.ClientSet.Add(client);    /// а вот тут вылетает ошибка!!! The entity type Clients is not part of the model for the current context.
                db.SaveChanges();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            while (ClientListBox.SelectedIndices.Count > 0)
            {
                using (var db = new Model1Container())
                { 
                int index = ClientListBox.SelectedIndices[0];
                var client = db.ClientSet.Where(c => c.Id == index).FirstOrDefault();
                ClientListBox.Items.RemoveAt(index);
                db.ClientSet.Remove(client);
                db.SaveChanges();
                    //Clients.RemoveAt(index);
                }
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
            
           /* foreach (Orders order in Clients[index].Order ) 
            {
                OrdersListBox.Items.Add(GetShort(order));
            }           
            */
        }

        public void AddOrderButton_Click(object sender, EventArgs e)
        {
            using (var db = new Model1Container())
            {
                int clientindex = ClientListBox.SelectedIndex;
                if (clientindex == -1) return;
                Clients client = db.ClientSet.Where(c => c.Id == clientindex).FirstOrDefault();

                int orderId = client.Order.Count + 1;  // вот эта строка мне не нравится, Напрашивается что то другое!!!!
                Orders order = new Orders { OrderName = $"Заказ {orderId}" };
                OrderForm f2 = new OrderForm();

                f2.SetOrder(order);


                f2.ShowDialog();
                if (f2.SaveOrder == true)
                {
                    client.Order.Add(order);
                    OrderTextBox.Text = order.ToString();
                    OrdersListBox.Items.Add(GetShort(order));
                }
            }
        }

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Model1Container())
            {
                int clientindex = ClientListBox.SelectedIndex;
                int orderindex = OrdersListBox.SelectedIndex;
                if (clientindex == -1 || orderindex == -1)
                {

                    OrderTextBox.Text = "";
                    return;
                }
                var order = db.OrderSet.Where(o => o.Id == orderindex).FirstOrDefault();
                var client = db.ClientSet.Where(c => c.Id == clientindex).FirstOrDefault();
                OrderTextBox.Text = client.Order.Where(o => o.Id == orderindex).FirstOrDefault().ToString();

                //OrderTextBox.Text = db.OrderSet.Where(o => o.Id == orderindex).FirstOrDefault();
                //OrderTextBox.Text = db.ClientSet.Where(c => c.Id == clientindex).Order.Where(o => o.Order.Id == orderindex);
                //OrderTextBox.Text = Client[clientindex].Orders[orderindex].ToString();

            }
        }

        private void DelOrderButton_Click(object sender, EventArgs e)
        {

            int clientindex = ClientListBox.SelectedIndex;
            int orderindex = OrdersListBox.SelectedIndex;
            if (clientindex == -1 || orderindex == -1)
            {

                OrderTextBox.Text = "";
                return;
            }
            while (OrdersListBox.SelectedIndices.Count > 0)
            {
                OrdersListBox.Items.RemoveAt(orderindex);
            //    Clients[clientindex].Order.RemoveAt(orderindex);
            }
        }
        private void ChangeButtonClick_Click(object sender, EventArgs e)
        {
            int clientindex = ClientListBox.SelectedIndex;
            int orderindex = OrdersListBox.SelectedIndex;
            if (clientindex == -1 || orderindex == -1)
            {

                OrderTextBox.Text = "";
                return;
            }
            OrderForm f2 = new OrderForm();
          /*  Orders order = Clients[clientindex].Orders[orderindex];
            f2.SetOrder(order);

            f2.ShowDialog();
                        
            OrderTextBox.Text = order.ToString();
            OrdersListBox.Items[orderindex] = GetShort(order);
            */


        }
        private string GetShort(Orders order)
        {
            return order.OrderName;
        }
    }
}
