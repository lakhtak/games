using System;

namespace CrossNullLogic.Computer
{
    class RandomXStartTactic : ITactic
    {
        private readonly Random _random = new Random();
        
        public bool DefinePoint(Player player, out int x, out int y)
        {
            x = _random.Next(GameField.FieldSize - 1);
            y = _random.Next(GameField.FieldSize - 1);
            return GameField.Empty;
        }
    }
}
