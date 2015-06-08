namespace WalrusEngishLogc
{
    public class Player
    {
        public string Name { get; private set; }
        public int Points { get; private set; }
        public int Fails { get; private set; }
        public bool Winner { get; private set; }

        public Player(string name)
        {
            Name = name;
            Points = 0;
            Fails = 0;
            Winner = false;
        }
    }
}
