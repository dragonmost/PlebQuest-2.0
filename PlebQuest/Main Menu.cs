using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlebServer;

namespace PlebQuest
{
    public partial class Form1 : Form
    {
        NameGenerator nameGenerator;

        private Game game;
        private GameCreation gameCreation;

        public Form1()
        {
            InitializeComponent();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            this.LoadCreationScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            //pleb = new Pleb(this.txtCreationName.Text, butCreationMale.Checked, stats, this.cheated);
        }

        private void butJoin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMenuUsername.Text)
                || string.IsNullOrWhiteSpace(this.txtMenuPassword.Text))
            {
                MessageBox.Show("Username and Password can't be empty");
                return;
            }

            string[] data = new string[] { Commands.PlayerConnection, txtMenuUsername.Text, Utils.sha256_hash(txtMenuPassword.Text) };
            Client.Instance.SendDataWithResponse(data);
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
            gameCreation.Randomize();

            this.txtCreationTotalStats.Text = gameCreation.TotalStats.ToString();
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
                gameCreation.MakePerfect();

                this.txtCreationTotalStats.Text = gameCreation.TotalStats.ToString();
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
            this.butCreationStart.Enabled = !string.IsNullOrWhiteSpace(this.txtCreationName.Text)
                && this.lstCreationRace.SelectedIndex != -1 && this.lstCreationClass.SelectedIndex != -1;
        }

        private void LoadCreationScreen()
        {
            this.nameGenerator = new NameGenerator();
            this.gameCreation = new GameCreation();
            Stats stats = gameCreation.Stats;

            PropertyInfo[] properties = stats.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                ListViewItem item = new ListViewItem(property.Name);
                item.Name = property.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[1].Text = property.GetValue(stats).ToString();
                lstCreationStat.Items.Add(item);
            }

            this.txtCreationTotalStats.Text = gameCreation.TotalStats.ToString();

            Task.Run(() =>
            {
                Race[] races = gameCreation.Races;
                Classe[] classes = gameCreation.Classes;

                this.Invoke(new MethodInvoker(() => 
                {
                    if (races != null)
                        this.lstCreationRace.Items.AddRange(races.Select(x => x.Name).ToArray());

                    if (classes != null)
                        this.lstCreationClass.Items.AddRange(classes.Select(x => x.Name).ToArray());
                }));                
            });

            this.txtCreationName.Text = nameGenerator.BuildName();

            this.pnlCharacterCreation.Visible = true;
        }

        private void txtCreationName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //shortcuts dont work
            var regex = new Regex(@"[^a-zA-Z0-9-\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
