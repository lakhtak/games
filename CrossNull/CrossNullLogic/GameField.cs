using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CrossNullLogic
{
    public class GameField
    {
        public const int FieldSize = 3;

        public static Symbol[,] Field = new Symbol[FieldSize, FieldSize];

        public static void Reset()
        {
            Field = new Symbol[FieldSize, FieldSize];
        }

        public static Symbol[] Diagonal1
        {
            get
            {
                var content = new Symbol[FieldSize];
                for (var i = 0; i < FieldSize; i++)
                {
                    content[i] = Field[i, i];
                }
                return content;
            }
        }

        public static Symbol[] Diagonal2
        {
            get
            {
                var content = new Symbol[FieldSize];
                for (var i = 0; i < FieldSize; i++)
                {
                    content[i] = Field[i, FieldSize - i - 1];
                }
                return content;
            }
        }

        public static Symbol[] Row(int number)
        {
            var content = new Symbol[FieldSize];
            for (var i = 0; i < FieldSize; i++)
            {
                content[i] = Field[number, i];
            }
            return content;
        }

        public static Symbol[] Column(int number)
        {
            var content = new Symbol[FieldSize];
            for (var i = 0; i < FieldSize; i++)
            {
                content[i] = Field[i, number];
            }
            return content;
        }

        public static Symbol[][] Rows
        {
            get
            {
                var content = new Symbol[FieldSize][];
                for (var i = 0; i < FieldSize; i++)
                {
                    content[i] = Row(i);
                }
                return content;
            }
        }

        public static Symbol[][] Columns
        {
            get
            {
                var content = new Symbol[FieldSize][];
                for (var i = 0; i < FieldSize; i++)
                {
                    content[i] = Column(i);
                }
                return content;
            }
        }

        public static Point[] EmptyCells
        {
            get
            {
                var emptyCells = new List<Point>();

                for (var i = 0; i < FieldSize; i++)
                {
                    for (var j = 0; j < FieldSize; j++)
                    {
                        if (Field[i, j] == Symbol.NoOne)
                            emptyCells.Add(new Point(i, j));
                    }
                }
                return emptyCells.ToArray();
            }           
        }

        public static Point[] Corners
        {
            get
            {
                return new[]
                {
                    new Point(0, 0),
                    new Point(0, FieldSize - 1),
                    new Point(FieldSize - 1, FieldSize - 1),
                    new Point(FieldSize - 1, 0)
                };
            }
        }

        public static Point[] Sides
        {
            get
            {
                return new[]
                {
                    new Point(0, 1),
                    new Point(1, 2),
                    new Point(2, 1),
                    new Point(1, 0)
                };
            }
        }

        public static bool Filled
        {
            get
            {
                return !Rows.Any(row => row.Any(cell => cell == Symbol.NoOne));
            }
        }

        public static bool Empty
        {
            get
            {
                return !Rows.Any(row => row.Any(cell => cell != Symbol.NoOne));
            }
        }
    }
}
