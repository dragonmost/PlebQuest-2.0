using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlebServer;

namespace PlebQuest.Frames
{
    public partial class FreMainMenu : UserControl
    {
        public MainMenu parentForm;

        public FreMainMenu()
        {
            InitializeComponent();
        }

        private void butMenuJoin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMenuUsername.Text)
                || string.IsNullOrWhiteSpace(this.txtMenuPassword.Text))
            {
                MessageBox.Show("Username and Password can't be empty");
                return;
            }

            string[] data = new string[] { Commands.PlayerConnection, txtMenuUsername.Text, Utils.sha256_hash(txtMenuPassword.Text) };
            //Client.Instance.SendDataWithResponse(data);
            DataBase.GetPleb(data[1], data[2]);
        }

        private void butMenuCreate_Click(object sender, EventArgs e)
        {
            frmAccountCreation frm = new frmAccountCreation();
            frm.ShowDialog();
        }

        private void butMenuNew_Click(object sender, EventArgs e)
        {
            this.parentForm.ShowPlebCreation();
        }

        private void butMenuPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
