# StateMachineExample

## Functionality

This code implements a state machine for a lamp using the [Stateless](https://www.nuget.org/packages/Stateless/) library. The lamp has three states: Off, On, and Error. There are two triggers: PressSwitch and GotError. Pressing the switch turns the lamp on and off, receiving an error sets the state to Error. If the switch is pressed in the error state, it returns to the off position.

## Commands

- Enter or PressSwitch(): Presses the lamp switch.
- GotError(): Triggers an error.
- Clear(): Clears the console.
- Exit(): Exits the program.

## Used Libraries

The main library used in this project is the [Stateless](https://www.nuget.org/packages/Stateless/) library for implementing the state machine.
