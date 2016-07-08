using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlebQuest
{
    class Game
    {
        private Form host;

        private Pleb pleb;

        private Mob mob;

        private Timer clock;

        private int ActionTime;

        private ActionState currentPlayerState = ActionState.Idle;

        public Game(Form host, Pleb pleb)
        {
            this.host = host;
            this.pleb = pleb;
            pleb.OnLevelUp += () => LevelUp();
            clock = new Timer();
            SetClockInterval();
        }

        private bool IsOnline
        {
            get
            {
                return Client.Instance.Connected;
            }

        }

        private void NewAction()
        {
            //choose a new Action
            //if IsOnline more action can be assigned
            ExecuteAction();
        }

        public void ExecuteAction()
        {
            switch(currentPlayerState)
            {
                case ActionState.Battle:
                    //host.pgbAction.Max = Battle(this.pleb, this.mob);

                    this.RefreshView();
                    clock.Start();
                    //host.CompletedAction += () => this.NewAction();
                    break;
                case ActionState.Dead:
                    break;
                case ActionState.Idle:
                    //maybe wait or something
                    NewAction();
                    break;
                case ActionState.Trade:
                    break;
                case ActionState.Default:
                    break;
            }
        }

        private void RefreshView()
        {
            //show pleb stats and stuff
        }

        private void GenerateMob()
        {
            
        }

        //affect pleb and return time needed to complete the battle
        private int Battle(ref Pleb pleb, Mob mob)
        {
            int time = 1;

            while(pleb.CurrentHP > 0 || mob.HP > 0)
            {
                //attack here
                time++;
            }

            pleb.Inventory.Add(mob.Drop);
            return time;
        }

        private void LevelUp()
        {
            SetClockInterval();
        }

        private void SetClockInterval()
        {
            //set according to pleb speed
        }
    }

    public enum ActionState
    {
        Battle,
        Dead,
        Duel,
        Helping,
        Idle,
        Merchant,
        Trade,
        Default
    };
}
