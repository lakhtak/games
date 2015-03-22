using System;

namespace CrossNullLogic
{
    public class Player
    {
        public Symbol Symbol { get; private set; }
        public string Name { get; private set; }
        public bool Winner { get; set; }
        protected IPlayerInteraction PlayerInteraction;

        protected Player(Symbol symbol, string name, IPlayerInteraction playerInteraction = null)
        {
            if (symbol == Symbol.NoOne)
                throw new InvalidOperationException("Нельзя задать игроку символ NoOne.");

            Name = name;
            Symbol = symbol;
            PlayerInteraction = playerInteraction;
        }

        public virtual void Move(out int x, out int y)
        {
            throw new NotImplementedException();
        }
    }
}
