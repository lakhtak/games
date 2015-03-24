namespace CrossNullLogic.Computer
{
    class GetCornerTactic : ITactic
    {
        public bool DefinePoint(Player player, out int x, out int y)
        {
            x = 0;
            y = 0;

            foreach (var corner in GameField.Corners)
            {
                if (GameField.Field[corner.X, corner.Y] != Symbol.NoOne)
                    continue;

                x = corner.X;
                y = corner.Y;
                return true;
            }

            return false;
        }
    }
}
