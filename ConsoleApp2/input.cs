using System;
class input
{
    static void Main () 
    {
        string name, course;
        Console.Write("\n\tVad heter du? \t\t");
        
        name = Console.ReadLine ();

        Console.Write("\n\tHej på dig, " + name + ',' +
            "\n\tVilken kurs läser du?   ");
        
        course = Console.ReadLine ();

        Console.WriteLine("\n\tVälkommen till "   + course +  "-kursen!n");




        




    }






}