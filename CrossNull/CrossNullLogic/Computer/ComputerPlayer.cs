using System;

namespace CrossNullLogic.Computer
{
    public class ComputerPlayer : Player
    {
        public delegate bool OutAction<in T1, T2, T3>(T1 a, out T2 b, out T3 c);

        public OutAction<Player, int, int>[] Tactics;

        public ComputerPlayer(Symbol symbol) : base(symbol, "Компьютер-" + symbol)
        {
            Tactics = new OutAction<Player, int, int>[]
            {
                new DefendOrWinTactic().DefinePoint,
                new GetCenterTactic().DefinePoint,
                new GetCornerTactic().DefinePoint,
                new GetSideTactic().DefinePoint,
                new RandomTactic().DefinePoint
            };
        }

        public override void Move(out int x, out int y)
        {
            x = 0;
            y = 0;

            foreach (var tactic in Tactics)
                if (tactic(this, out x, out y))
                {
                    if (GameField.Field[x, y] != Symbol.NoOne)
                        throw new InvalidOperationException(string.Format("Неверная логика компьютера: Поле ({0} , {1}) уже занято.", x, y));
                    return; 
                }
        }
    }
}
