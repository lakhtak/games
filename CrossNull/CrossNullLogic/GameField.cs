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

        public static bool Filled
        {
            get
            {
                return !Rows.Any(row => row.Any(cell => cell == Symbol.NoOne));
            }
        }
    }
}
