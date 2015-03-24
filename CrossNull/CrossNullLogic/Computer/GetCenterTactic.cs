namespace CrossNullLogic.Computer
{
    class GetCenterTactic : ITactic
    {
        public bool DefinePoint(Player player, out int x, out int y)
        {
            x = y = 1;
            return !GameField.Empty && GameField.Field[1, 1] == Symbol.NoOne;
        }
    }
}
