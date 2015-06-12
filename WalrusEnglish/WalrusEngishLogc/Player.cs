namespace WalrusEngishLogc
{
    public class Player
    {
        public string Name { get; private set; }
        public int Points { get; private set; }
        public int Fails { get; private set; }
        public bool LastChance { get; private set; }

        public Player(string name, bool lastChance = false)
        {
            Name = name;
            Points = 0;
            Fails = 0;
            LastChance = lastChance;
        }

        public void UseLastChance()
        {
            LastChance = false;
        }

        public bool Winner
        {
            get
            {
                return Points >= Game.PointsToWin;
            }
        }

        public bool Loser
        {
            get
            {
                return Fails > Game.FailsToLose;
            }
        }

        public void IncreasePoints()
        {
            Points += Constants.OneSuccessCost;
        }

        public void IncreaseFails()
        {
            Fails++;
        }
    }
}
