namespace CrossNullLogic
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(Symbol symbol, string name, IPlayerInteraction playerInteraction) : base(symbol, name, playerInteraction) { }

        public override void Move(out int x, out int y)
        {
            do
            {
            } while (!PlayerInteraction.TryGetCoordinates(this, out x, out y));
        }
    }
}
