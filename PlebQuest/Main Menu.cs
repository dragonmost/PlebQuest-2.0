using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlebServer;

namespace PlebQuest
{
    public partial class Form1 : Form
    {
        NameGenerator nameGenerator;

        Stats stats;
        Pleb pleb;

        Race[] races;
        Classe[] classes;

        public Form1()
        {
            InitializeComponent();
            nameGenerator = new NameGenerator();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            this.LoadCreationScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stats = new Stats();
            stats.Randomize();
            PropertyInfo[] properties = stats.GetType().GetProperties();
            int total = 0;

            foreach (PropertyInfo property in properties)
            {
                ListViewItem item = new ListViewItem(property.Name);
                item.Name = property.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[1].Text = property.GetValue(stats).ToString();
                lstCreationStat.Items.Add(item);

                total += (int)property.GetValue(stats);
            }

            this.txtCreationTotalStats.Text = total.ToString();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            pleb = new Pleb(this.txtCreationName.Text, butCreationMale.Checked, stats, this.cheated);
        }

        private void butJoin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMenuUsername.Text)
                || string.IsNullOrWhiteSpace(this.txtMenuPassword.Text))
            {
                MessageBox.Show("Username and Password can't be empty");
                return;
            }

            Client.Instance.SendData(new string[] { Commands.PlayerConnection, txtMenuUsername.Text, txtMenuPassword.Text });
        }

        private void butPlay_Click(object sender, EventArgs e)
        {

        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            frmAccountCreation frm = new frmAccountCreation();
            frm.ShowDialog();
        }

        private void butCancelCreation_Click(object sender, EventArgs e)
        {
            this.pnlCharacterCreation.Visible = false;
        }

        private void butRoll_Click(object sender, EventArgs e)
        {
            stats.Randomize();
            int total = 0;

            foreach (PropertyInfo property in stats.GetType().GetProperties())
            {
                ListViewItem item = lstCreationStat.Items.Find(property.Name, true).First();
                item.SubItems[1].Text = property.GetValue(stats).ToString();

                total += (int)property.GetValue(stats);
            }

            this.txtCreationTotalStats.Text = total.ToString();
        }

        private Queue<Keys> keySequence = new Queue<Keys>();
        private bool cheated = false;

        private void txtCreationTotalStats_KeyDown(object sender, KeyEventArgs e)
        {
            keySequence.Enqueue(e.KeyCode);

            if (keySequence.Count > Cheat.Konami.Count)
                keySequence.Dequeue();

            if (keySequence.SequenceEqual(Cheat.Konami))
            {
                stats = new Stats();
                stats.Perfect();
                int total = 0;

                foreach (PropertyInfo property in stats.GetType().GetProperties())
                {
                    ListViewItem item = lstCreationStat.Items.Find(property.Name, true).First();
                    item.SubItems[1].Text = property.GetValue(stats).ToString();

                    total += (int)property.GetValue(stats);
                }
                this.txtCreationTotalStats.Text = total.ToString();
                this.cheated = true;
            }

        }

        private void txtCreationTotalStats_Leave(object sender, EventArgs e)
        {
            keySequence = new Queue<Keys>();
        }

        private void butGenerate_Click(object sender, EventArgs e)
        {
            this.txtCreationName.Text = nameGenerator.BuildName();
        }

        private void SetControlState(object sender, EventArgs e)
        {
            this.butCreationStart.Enabled = string.IsNullOrWhiteSpace(this.txtCreationName.Text)
                && this.lstCreationRace.SelectedIndex != -1 && this.lstCreationClass.SelectedIndex != -1;
        }

        private void LoadCreationScreen()
        {
            Task.Run(() =>
            {
                this.races = Client.Instance.GetDBOject<Race>("races");
                this.classes = Client.Instance.GetDBOject<Classe>("Classes");

                this.Invoke(new MethodInvoker(() => 
                {
                    if (this.races != null)
                        this.lstCreationRace.Items.AddRange(this.races.Select(x => x.Name).ToArray());

                    if (this.classes != null)
                        this.lstCreationClass.Items.AddRange(this.classes.Select(x => x.Name).ToArray());
                }));                
            });

            this.pnlCharacterCreation.Visible = true;
            this.txtCreationName.Text = nameGenerator.BuildName();
        }
    }
}
