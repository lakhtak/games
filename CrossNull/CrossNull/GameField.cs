using System;
using System.Linq;

namespace CrossNull
{
    static class GameField
    {
        public const int FieldSize = 3;

        public static Who[,] Field = new Who[FieldSize, FieldSize];

        public static Who[] Diagonal1
        {
            get
            {
                var content = new Who[FieldSize];
                for (var i = 0; i < FieldSize; i++)
                {
                    content[i] = Field[i, i];
                }
                return content;
            }
        }

        public static Who[] Diagonal2
        {
            get
            {
                var content = new Who[FieldSize];
                for (var i = 0; i < FieldSize; i++)
                {
                    content[i] = Field[i, FieldSize - i - 1];
                }
                return content;
            }
        }

        public static Who[] Row(int number)
        {
            var content = new Who[FieldSize];
            for (var i = 0; i < FieldSize; i++)
            {
                content[i] = Field[number, i];
            }
            return content;
        }

        public static Who[] Column(int number)
        {
            var content = new Who[FieldSize];
            for (var i = 0; i < FieldSize; i++)
            {
                content[i] = Field[i, number];
            }
            return content;
        }

        public static Who[][] Rows
        {
            get
            {
                var content = new Who[FieldSize][];
                for (var i = 0; i < FieldSize; i++)
                {
                    content[i] = Row(i);
                }
                return content;
            }
        }

        public static Who[][] Columns
        {
            get
            {
                var content = new Who[FieldSize][];
                for (var i = 0; i < FieldSize; i++)
                {
                    content[i] = Column(i);
                }
                return content;
            }
        }

        public static bool Filled
        {
            get
            {
                return !Rows.Any(row => row.Any(cell => cell == Who.NoOne));
            }
        }

        public static void Print()
        {
            foreach (var row in Rows)
            {
                Console.WriteLine(string.Join(" ", row.Select(cell => cell == Who.NoOne ? "*" : cell.ToString())));
            }
        }
    }
}
