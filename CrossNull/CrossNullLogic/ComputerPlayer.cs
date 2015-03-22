namespace CrossNullLogic
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(Symbol symbol) : base(symbol, "Компьютер") { }

        public override void Move(out int x, out int y)
        {
            throw new System.NotImplementedException();
        }
    }
}
