namespace CrossNullLogic.Computer
{
    class WinTactic : ITactic
    {
        public bool DefinePoint(Player player, out int x, out int y)
        {
            return WinOrDefend.FindOneCellLeftLine(player.Symbol, out x, out y);
        }
    }
}
