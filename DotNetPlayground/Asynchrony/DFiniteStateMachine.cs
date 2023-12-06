namespace Asynchrony;

internal enum State
{
    Idle,
    Started,
    Processing,
    Done
}

internal enum Command
{
    Start,
    Process,
    Done
}

internal class DFiniteStateMachine
{
    private State _state = State.Idle;
    
    public void MoveNext(Command command)
    {
        switch (command)
        {
            case Command.Start:
                Console.WriteLine("Starting payment processing...");
                _state = State.Started;
                break;
            case Command.Process:
                Console.WriteLine("Payment is processing...");
                _state = State.Processing;
                break;
            case Command.Done:
                Console.WriteLine("Payment processed.");
                _state = State.Done;
                break;
            default:
                throw new Exception("Invalid state");
        }
    }
}