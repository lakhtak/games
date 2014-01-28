using System.Drawing;

namespace WalrusSeaFight
{
    public partial class GameField
    {
        public void Paint(Graphics drawArea)
        {
            DrawEmptyCells(drawArea);
            DrawMissed(drawArea);
            DrawShips(drawArea);
        }

        private void DrawShips(Graphics drawArea)
        {
            throw new System.NotImplementedException();
        }

        private void DrawMissed(Graphics drawArea)
        {
            throw new System.NotImplementedException();
        }

        private void DrawEmptyCells(Graphics drawArea)
        {
            throw new System.NotImplementedException();
        }
    }
}
