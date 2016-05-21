using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlebQuest
{
    public partial class frmAccountCreation : Form
    {
        public frmAccountCreation()
        {
            InitializeComponent();
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.txtUsername.Text) 
                || string.IsNullOrWhiteSpace(this.txtPassword.Text)
                || string.IsNullOrWhiteSpace(this.txtRetype.Text))
            {
                MessageBox.Show("Please fill that form first!");
                return;
            }

            if(this.txtPassword.Text != this.txtRetype.Text)
            {
                MessageBox.Show("Password are not the same!");
                return;
            }

            if(this.txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Password must be atleast 5 characters long!");
                return;
            }

            Client client = new Client("localhost");
            if(!client.CreateAccount(this.txtUsername.Text, this.txtPassword.Text))
            {
                MessageBox.Show("User already exists!");
                return;
            }

            this.Dispose();
        }
    }
}
