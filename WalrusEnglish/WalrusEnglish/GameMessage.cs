using System;
using System.Collections.Generic;
using System.Linq;

namespace WalrusEnglishGui
{
    static class GameMessage
    {

        private static readonly Dictionary<MessageType, string> RussianMessageDictionary = new Dictionary
            <MessageType, string>
        {
            { MessageType.Hello, "ПРИВЕТ!\nДанная игра сделана с целью обучить вас английским словам.\nНаслаждайтесь игрой." },
            { MessageType.CorrectAnswer, "Молодец, {0}! Твой ответ правильный! Ты получаешь {1} очко(а)." },
            { MessageType.IncorrectAnswer, "Извини, {0}, но это неверно! Теперь у тебя {1} промах(а)(ов)" },
            { MessageType.Lose, "О НЕТ! {0} проиграл игру." },
            { MessageType.MakeMove, "Сейчас твоя очередь, {0}\nПожалуйста выбери корректный перевод слова" },
            { MessageType.Win, "Поздравляем! {0} победитель!!!" }
        };

        private static readonly Dictionary<MessageType, string> EnglishMessageDictionary = new Dictionary
            <MessageType, string>
        {
            { MessageType.Hello, "HI!\nThis game is made to teach you english words.\nEnjoy the game." },
            { MessageType.CorrectAnswer, "Well done, {0}! Your answer is correct! You get {1} point(s)." },
            { MessageType.IncorrectAnswer, "Sorry, {0}, but this is wrong! You now have {1} fail(s)." },
            { MessageType.Lose, "Oh NO! {0} loses the game." },
            { MessageType.MakeMove, "Now it's your turn, {0}\nPlease select the correct translation of the word" },
            { MessageType.Win, "Congratulations! {0} is the winner!!!" }
        };

        private static readonly Dictionary<MessageType, string> MessageDictionary = RussianMessageDictionary; 
        
        public static string Text(MessageType type)
        {
            return MessageDictionary.First(message => message.Key == type).Value;
        }
    }
}