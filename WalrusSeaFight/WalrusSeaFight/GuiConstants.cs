using System.Drawing;
using Logic;
using WalrusSeaFight.Properties;

namespace WalrusSeaFight
{
    public static class GuiConstants
    {
        public const string WindowTitle = "Моржебой :[";
        public const int NominalWindowHeight = 800;
        public const int NominalWindowWidth = 600;
        
        public const int CellSize = 30;
        public static readonly int GameFieldSize = CellSize * GameConstants.CellCount;

        public static readonly Bitmap EmptyImage = Resources.empty;
        public static readonly Bitmap UnknownImage = Resources.unknown;
        public static readonly Bitmap ShipImage = Resources.ship;
        public static readonly Bitmap BombedImage = Resources.bombed;
        public static readonly Bitmap KilledImage = Resources.killed;
        public static readonly Bitmap MissImage = Resources.miss;
    }
}
