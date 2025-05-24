using System;

class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(" Santos ");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" Barcelona ");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(" Los Angeles Lakers ");
        Console.ResetColor();
    }
}
