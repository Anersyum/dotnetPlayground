namespace FunTimes;
internal enum State
{
    Idle,
    Started,
    Processing,
    Done
}

internal static class DFiniteStateMachine
{
    public static void Transition(StateBase trasnitioningObject, State state)
    {
        trasnitioningObject.State = state;
    }

    public static void MoveNext(StateBase transitionObject)
    {
        switch (transitionObject.State)
        {
            case State.Idle:
                Console.WriteLine("Starting payment processing...");
                transitionObject.State = State.Started;
                break;
            case State.Started:
                Console.WriteLine("Payment is processing...");
                transitionObject.State = State.Processing;
                break;
            case State.Processing:
                Console.WriteLine("Payment processed.");
                transitionObject.State = State.Done;
                break;
            default:
                throw new Exception("Invalid state");
        }
    }
}


abstract class StateBase
{
    public State State { get; set; } = State.Idle;
}

internal sealed class Payment : StateBase { }
