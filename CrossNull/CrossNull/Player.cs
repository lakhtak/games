using System;

namespace CrossNull
{
    class Player
    {
        public Who Symbol { get; private set; }
        public string Name { get; private set; }
        public bool Winner { get; set; }

        protected Player(Who symbol, string name)
        {
            if (symbol == Who.NoOne)
                throw new InvalidOperationException("Нельзя задать игроку символ NoOne.");

            Name = name;
            Symbol = symbol;
        }

        public virtual void Move(out int x, out int y)
        {
            throw new NotImplementedException();
        }
    }
}
