namespace CrossNullLogic
{
    public interface IPlayerInteraction
    {
        bool TryGetCoordinates(Player player, out int x, out int y);
    }
}
