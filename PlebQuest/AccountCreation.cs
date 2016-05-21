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
            if(this.txtPassword.Text != this.txtRetype.Text)
            {
                MessageBox.Show("Password are not the same!");
                return;
            }

            Client client = new Client("localhost");
            if(!client.CreateAccount(this.txtUsername.Text, this.txtPassword.Text))
            {
                MessageBox.Show("User already exists");
                return;
            }
        }
    }
}
