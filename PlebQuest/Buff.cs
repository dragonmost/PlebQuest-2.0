namespace PlebQuest
{
    class Buff
    {
        private int ID;

        public string Name { get; set; }

        public int NbTurn { get; set; }

        public Stats StatChange { get; set; }
        public int HPChange { get; set; }
    }
}
