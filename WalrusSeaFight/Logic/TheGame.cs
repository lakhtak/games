using System;

namespace Logic
{
    public class TheGame
    {
        public static State State { get; set; }

        public static void ChangeState(State newState)
        {
            var oldState = State;
            State = newState;
            if (GameStateChanged != null)
                GameStateChanged(null, new StateEventArgs(oldState, newState));
        }

        public static event EventHandler<StateEventArgs> GameStateChanged;
    }

    public class StateEventArgs : EventArgs
    {
        public StateEventArgs(State oldState, State newState)
        {
            OldState = oldState;
            NewState = newState;
        }

        public State OldState { get; private set; }
        public State NewState { get; private set; }
    }
}
