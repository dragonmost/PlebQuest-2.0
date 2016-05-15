using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlebQuest
{
    public static class Cheat
    {
        public static Queue<Keys> Konami;

        static Cheat()
        {
            Konami = new Queue<Keys>();
            Konami.Enqueue(Keys.Up);
            Konami.Enqueue(Keys.Up);
            Konami.Enqueue(Keys.Down);
            Konami.Enqueue(Keys.Down);
            Konami.Enqueue(Keys.Left);
            Konami.Enqueue(Keys.Right);
            Konami.Enqueue(Keys.Left);
            Konami.Enqueue(Keys.Right);
            Konami.Enqueue(Keys.B);
            Konami.Enqueue(Keys.A);
            Konami.Enqueue(Keys.Enter);
        }
    }
}
