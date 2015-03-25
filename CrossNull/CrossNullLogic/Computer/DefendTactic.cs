namespace CrossNullLogic.Computer
{
    class DefendTactic : ITactic
    {
        public bool DefinePoint(Player player, out int x, out int y)
        {
            return WinOrDefend.FindOneCellLeftLine(player.OpponentSymbol, out x, out y);
        }
    }
}
