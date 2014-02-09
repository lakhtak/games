using System;

namespace Logic
{
    public class TheGame
    {
        public static State State { get; set; }

        public static event Action<State> GameStateChanged;

        public static void ChangeState(State newState)
        {
            State = newState;
            if (GameStateChanged != null)
                GameStateChanged(newState);
        }
    }
}
