using Stateless;

namespace StateMachineExample;

public class LightStateMachine
{
    private readonly StateMachine<State, Trigger> _machine;

    public State CurrentState => _machine.State;

    public LightStateMachine()
    {
        _machine = new StateMachine<State, Trigger>(State.Off);

        _machine.Configure(State.Off)
            .Permit(Trigger.PressSwitch, State.On);

        _machine.Configure(State.On)
            .Permit(Trigger.PressSwitch, State.Off)
            .Permit(Trigger.GotError, State.Error);

        _machine.Configure(State.Error)
            .Permit(Trigger.PressSwitch, State.Off);
    }

    public void PressSwitch()
    {
        try
        {
            _machine.Fire(Trigger.PressSwitch);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid operation: " + ex.Message);
        }
    }
    public void GotError()
    {
        try
        {
            _machine.Fire(Trigger.GotError);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid operation: " + ex.Message);
        }
    }

}
