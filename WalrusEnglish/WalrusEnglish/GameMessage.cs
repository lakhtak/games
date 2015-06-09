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
                "Now it's your turn, {0}\n" + 
                "Please select the correct translation of the word", 
                "Сейчас ваша очередь, {0}\n" + 
                "Пожалуйста выберите корректный перевод слова"),
            new Tuple<MessageType, string, string>(MessageType.CorrectAnswer, "Well done, {0}! Your answer is correct! You get {1} point(s).",
                "Молодец, {0}! Твой ответ правильный! Ты получаешь {1} очко(а)."),
            new Tuple<MessageType, string, string>(MessageType.IncorrectAnswer, "Sorry, {0}, but this is wrong! You now have {1} fail(s).",
                "Извини, {0}, но это неверно! Теперь у тебя {1} промах(а)(ов)"),
            new Tuple<MessageType, string, string>(MessageType.Win, "Congratulations! {0} is the winner!!!",
                "Поздравляем! {0} победитель!!!"),
            new Tuple<MessageType, string, string>(MessageType.Lose, "Oh NO! {0} loses the game.",
                "О НЕТ! {0} проиграл игру.")
        };
    }
}