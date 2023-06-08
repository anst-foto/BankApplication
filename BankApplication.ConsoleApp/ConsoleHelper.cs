namespace BankApplication.ConsoleApp;

public static class ConsoleHelper
{
    private static void PrintLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    private static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }

    public static void PrintInfo(string message)
    {
        PrintLine(message, ConsoleColor.Blue);
    }
    public static void PrintWarning(string message)
    {
        PrintLine(message, ConsoleColor.Yellow);
    }

    public static string Input(string message)
    {
        Print(message, ConsoleColor.Cyan);
        return Console.ReadLine();
    }
}