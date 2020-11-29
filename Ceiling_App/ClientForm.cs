using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ceiling_App.Model;

namespace Ceiling_App
{
    public partial class ClientForm : Form
    {
        private Client client;
        public bool SaveClient;

        public ClientForm()
        {
            InitializeComponent();
            
        }
        public void SetClient(Client client)
        {
            this.client = client;
            if (client.FirstName != null) { ClientNameField.Text = client.FirstName.ToString(); }
            if (client.FirstName != null) { ClientLastnameField.Text = client.LastName.ToString(); }

        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveClient = true;
            client.FirstName = ClientNameField.Text;
            client.LastName = ClientLastnameField.Text;

            Close();
        }

        private void CancellButton_Click(object sender, EventArgs e)
        {
            SaveClient = false;
            Close();
        }
    }
 
}
