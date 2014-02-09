using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Logic
{
    public static class GameAction
    {
        public static void AllocateShipsRandomly(GameField gameField)
        {
            gameField.Clear();

            var random = new Random();

            for (var shipLength = GameConstants.MaxLength; shipLength > 0; shipLength--)
            {
                for (var i = 0; i <= GameConstants.MaxLength - shipLength; i++)
                {
                    var possibleAllocations = new List<Ship>();
                    possibleAllocations.AddRange(GetPossibleAllocations(gameField, shipLength, horizontal: true));
                    possibleAllocations.AddRange(GetPossibleAllocations(gameField, shipLength, horizontal: false));

                    gameField.AddShip(possibleAllocations[random.Next(possibleAllocations.Count)]);
                }
            }
        }

        private static IEnumerable<Ship> GetPossibleAllocations(GameField gameField, int shipLength, bool horizontal)
        {
            var possibleAllocations = new List<Ship>();
            var cellCountMinusLength = GameConstants.CellCount - shipLength + 1;
            for (var x = 1; x <= (horizontal ? cellCountMinusLength : GameConstants.CellCount); x++)
            {
                for (var y = 1; y <= (horizontal ? GameConstants.CellCount : cellCountMinusLength); y++)
                {
                    var ship = new Ship(x, y, shipLength, horizontal);
                    if (gameField.AddShip(ship, reallyAdd:false))
                        possibleAllocations.Add(ship);                    
                }
            }
            return possibleAllocations;
        }

        public static void BombOpponent(int x, int y)
        {
            if (!OpponentsField.Instance.Bomb(x, y))
            {
                TheGame.ChangeState(State.OpponentsTurn);
                return;
            }

            if (OpponentsField.Instance.Ships.All(ship => ship.Killed))
                TheGame.ChangeState(State.GameOver);
            else
                TheGame.ChangeState(State.PlayerTurn);
        }

        public static void BombPlayer(int x, int y)
        {
            if (!PlayerField.Instance.Bomb(x, y))
            {
                TheGame.ChangeState(State.PlayerTurn);
                return;
            }

            if (PlayerField.Instance.Ships.All(ship => ship.Killed))
                TheGame.ChangeState(State.GameOver);
            else
                TheGame.ChangeState(State.OpponentsTurn);
        }
    }
}
