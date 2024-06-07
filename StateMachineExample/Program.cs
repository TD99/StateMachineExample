namespace StateMachineExample;

internal class Program
{
    public static void Main()
    {
        var flashlight = new LightStateMachine();
        var exit = false;

        PrintHeader();

        while (!exit)
        {
            Console.WriteLine($"Current State: {flashlight.CurrentState}");
            Console.WriteLine("_________________________________");
            Console.WriteLine("");
            Console.Write("Enter command: ");
            switch (Console.ReadLine())
            {
                case "Exit()":
                    exit = true;
                    break;
                case "Clear()":
                    Console.Clear();
                    PrintHeader();
                    break;
                case "GotError()":
                    flashlight.GotError();
                    break;
                case "": // enter
                case "PressSwitch()":
                    flashlight.PressSwitch();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }

    private static void PrintHeader()
    {
        Console.WriteLine("Lamp StateMachine Example");
        Console.WriteLine("Made by Tim Dürr (@TD99) using Stateless Library.");
        Console.WriteLine("");
        Console.WriteLine("=======================================================");
        Console.WriteLine("Press Enter or enter PressSwitch() to press the switch.");
        Console.WriteLine("Enter GotError() to throw an exception.");
        Console.WriteLine("");
        Console.WriteLine("Enter Clear() to clear the console.");
        Console.WriteLine("Enter Exit() to exit the program.");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");
    }
}