namespace CrossNull
{
    class Computer : Player
    {
        public Computer(Who symbol) : base(symbol, "Компьютер") { }

        public override void Move(out int x, out int y)
        {
            throw new System.NotImplementedException();
        }
    }
}
