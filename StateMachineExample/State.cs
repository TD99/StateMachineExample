namespace StateMachineExample;

public enum State
{
    Off,
    On,
    Error
}

public enum Trigger
{
    PressSwitch,
    GotError
}