using System;
using System.Linq;

namespace WalrusEnglishGui
{
    static class GameMessage
    {
        public static string Russian(MessageType type)
        {
            return MessageDictionary.First(message => message.Item1 == type).Item3;
        }

        public static string English(MessageType type)
        {
            return MessageDictionary.First(message => message.Item1 == type).Item2;
        }

        private static readonly Tuple<MessageType, string, string>[] MessageDictionary =
        {
            new Tuple<MessageType, string, string>(MessageType.Hello, 
                "HI!\n" +
                "This game is made to teach you english words.\n" + 
                "Enjoy the game.",
                "ПРИВЕТ!\n" +
                "Данная игра сделана с целью обучить вас английским словам.\n" +
                "Наслаждайтесь игрой."),
            new Tuple<MessageType, string, string>(MessageType.MakeMove,
                "Please select the correct translation of the word", "Пожалуйста выберите корректный перевод слова"),
            new Tuple<MessageType, string, string>(MessageType.Win, "Congratulations! {0} is the winner!!!",
                "Поздравляем! {0} победитель!!!")
        };
    }
}