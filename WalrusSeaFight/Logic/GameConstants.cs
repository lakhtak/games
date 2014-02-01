using System;

namespace Logic
{
    public static class GameConstants
    {
        public const string WindowTitle = "Моржебой :[";
        public const int CellCount = 10;
        
        public const int MaxLength = 4;

        public static readonly TimeSpan ComputerThinkTime = TimeSpan.FromSeconds(10);
    }
}
