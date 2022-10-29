

using System;

class Input
{
    static void Main()
    {
        string name, course;

        Console.Write("\n\tVad heter du?\t\t");
        name = Console.ReadLine();

        Console.Write("\n\tHej på dig, " + name +
                      "\n\tvilken kurs läser du? ");
        
        course = Console.ReadLine();

        Console.WriteLine("\n\tVälkommen till " + course +
                                                "-kursen!\n");
            



    }
}

