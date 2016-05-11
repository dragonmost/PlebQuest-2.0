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
    public partial class Form1 : Form
    {
        Pleb p = new Pleb();

        public Form1()
        {
            InitializeComponent();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            //pnlCharacterCreation.Visible = true;

            p.CurrentExp += 4;

            this.Text = p.CurrentExp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p.CurrentExp = 90;

            this.Text = p.CurrentExp.ToString();
        }
    }
}
