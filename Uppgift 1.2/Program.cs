using System;
namespace Uppgift1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            for (int i = 0; i < 7; i++) 
            {
                Console.WriteLine();
            }
            Console.WriteLine("                                  Windows");
            Console.WriteLine();
            Console.WriteLine("     An error has occured. To continue:");
            Console.WriteLine();
            Console.WriteLine("     Press Enter to return to Windows, or");
            Console.WriteLine();
            Console.WriteLine("     Press CTRL+ALT+DEL to restart your computer. If you do this");
            Console.WriteLine("     you will lose any unsaved information in all open applications");
            Console.WriteLine();
            Console.WriteLine("     Error: 0E : 016F : BFF9B3D4");
            Console.WriteLine();
            Console.WriteLine("                         Press any key to continue");
            Console.ReadKey();
        }
    }
}