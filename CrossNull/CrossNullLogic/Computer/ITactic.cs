namespace CrossNullLogic.Computer
{
    interface ITactic
    {
        bool DefinePoint(Player player, out int x, out int y);
    }
}
