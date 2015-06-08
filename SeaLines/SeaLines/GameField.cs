using System.Drawing;

namespace SeaLines
{
    public static class GameField
    {
        public static Color[,] Field = new Color[Constants.CellCount, Constants.CellCount];

        static GameField()
        {
            Reset();
        }

        public static void Reset()
        {
            for (var i = 0; i < Field.GetLength(0); i++)
            {
                for (var j = 0; j < Field.GetLength(1); j++)
                {
                    Field[i, j] = Color.Red;
                }
            }
        }

        public static Color[] Row(int number)
        {
            var content = new Color[Constants.CellCount];
            for (var i = 0; i < Constants.CellCount; i++)
            {
                content[i] = Field[number, i];
            }
            return content;
        }

        public static Color[] Column(int number)
        {
            var content = new Color[Constants.CellCount];
            for (var i = 0; i < Constants.CellCount; i++)
            {
                content[i] = Field[i, number];
            }
            return content;
        }

        public static Color[][] Rows
        {
            get
            {
                var content = new Color[Constants.CellCount][];
                for (var i = 0; i < Constants.CellCount; i++)
                {
                    content[i] = Row(i);
                }
                return content;
            }
        }

        public static Color[][] Columns
        {
            get
            {
                var content = new Color[Constants.CellCount][];
                for (var i = 0; i < Constants.CellCount; i++)
                {
                    content[i] = Column(i);
                }
                return content;
            }
        }
    }
}
