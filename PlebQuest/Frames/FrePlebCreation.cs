using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace PlebQuest.Frames
{
    public partial class FrePlebCreation : UserControl
    {
        private NameGenerator nameGenerator;

        private GameCreation gameCreation;

        public MainMenu parentForm;

        public FrePlebCreation()
        {
            InitializeComponent();
        }

        private void butCancelCreation_Click(object sender, EventArgs e)
        {
            
        }

        private void butRoll_Click(object sender, EventArgs e)
        {
            gameCreation.Randomize();

            this.txtCreationTotalStats.Text = gameCreation.TotalStats.ToString();
            this.lstCreationStat.Items.Clear();
            foreach (PropertyInfo property in gameCreation.Stats.GetType().GetProperties())
            {
                ListViewItem item = new ListViewItem(property.Name);
                item.Name = property.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[1].Text = property.GetValue(gameCreation.Stats).ToString();
                lstCreationStat.Items.Add(item);
            }
        }

        private bool isLoaded;

        public void LoadCreationScreen()
        {
            if (isLoaded)
                return;

            this.nameGenerator = new NameGenerator();
            this.gameCreation = new GameCreation();
            Stats stats = gameCreation.Stats;

            PropertyInfo[] properties = stats.GetType().GetProperties();

            this.lstCreationStat.Items.Clear();
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
                    this.lstCreationRace.Items.Clear();
                    if (races != null)
                        this.lstCreationRace.Items.AddRange(races.Select(x => x.Name).ToArray());

                    this.lstCreationClass.Items.Clear();
                    if (classes != null)
                        this.lstCreationClass.Items.AddRange(classes.Select(x => x.Name).ToArray());
                }));
            });

            this.txtCreationName.Text = nameGenerator.BuildName();

            this.pnlCharacterCreation.Visible = true;
            this.isLoaded = true;
        }

        private void butGenerate_Click(object sender, EventArgs e)
        {
            this.txtCreationName.Text = nameGenerator.BuildName();
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

        private void butCreationStart_Click(object sender, EventArgs e)
        {
            //this.parentForm.StartGame(
            //new Pleb(this.txtCreationName.Text, butCreationMale.Checked, this.gameCreation.Stats, this.cheated));
        }
    }
}
