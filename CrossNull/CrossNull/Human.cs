using System;

namespace CrossNull
{
    class Human : Player
    {
        public Human(Who symbol, string name) : base(symbol, name) { }

        public override void Move(out int x, out int y)
        {
            do
            {
                Console.WriteLine("\r\nИгрок {0} ходит {1}-ками. Введите ДВЕ цифры от 1 до {2}, первая - номер строки и вторая - номер колонки куда хотите поставить свой {1}.", Name, Symbol, GameField.FieldSize);
            } while (!TryParseInput(Console.ReadLine(), out x, out y));
        }

        private bool TryParseInput(string inputString, out int x, out int y)
        {
            x = 0;
            y = 0;

            if (inputString.Length != 2 )
            {
                Console.WriteLine("Ошибка: Вы неверно ввели две цифры :)");
                return false;
            }

            if (!IsDigitInsideField(inputString.Substring(0, 1), out x) || !IsDigitInsideField(inputString.Substring(1, 1), out y)) 
                return false;

            if (GameField.Field[x, y] != Who.NoOne)
            {
                Console.WriteLine("Ошибка: Поле ({0}, {1}) уже занято, вы не можете поставить туда {2}.", x + 1, y + 1, Symbol);
                return false;
            }

            return true;
        }

        private bool IsDigitInsideField(string input, out int output)
        {
            output = 0;

            try
            {
                output = Convert.ToInt32(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: {0} не число.", input);
                return false;
            }

            if (output < 1 || output > GameField.FieldSize)
            {
                Console.WriteLine("Ошибка, {0} за границами игрового поля.", output);
                return false;
            }

            output--;

            return true;
        }
    }
}
