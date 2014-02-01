﻿using System;
using System.Collections.Generic;

namespace Logic
{
    public static class Allocator
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
    }
}