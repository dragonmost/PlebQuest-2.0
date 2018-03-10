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
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
            this.freMainMenu.parentForm = this;
            this.frePlebCreation.parentForm = this;
            this.freGame.parentForm = this;

            this.freGame.CreateGamePanels();
            this.freGame.RefreshQuest(null, null, "Fetch 3 left goblin ears from the same goblin"); 
        }

        public void CancelPlebCreation()
        {

        }

        public void StartGame(Pleb pleb)
        {

        }

        public void ShowPlebCreation()
        {
            this.frePlebCreation.LoadCreationScreen();
            this.frePlebCreation.BringToFront();
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

        public void RefreshHP(int currentHP, int maxHP)
        {
            this.freGame.RefreshHP(currentHP, maxHP);
        }

        public void RefreshSpeels(List<Speel> speelBook)
        {
            this.freGame.RefreshSpeels(speelBook);
        }

        public void RefreshStats(Stats stats)
        {
            this.freGame.RefreshStats(stats);
        }
    }
}
