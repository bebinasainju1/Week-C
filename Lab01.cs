using System;

public class Lab01
{
    public static void Main()
    {
        Console.WriteLine("CS 201 Restaurant Guide\n");
        String response;
        char s, f;
        bool spicy,fancy;
        
        Console.Write("Do you like spicy food?(y/n):");

        response = Console.ReadLine();//Console.ReadLine() provides the interface for reading data
        s = response[0];//This is the first character of the string

        if ((s == 'y') || (s == 'Y'))
            spicy = true;
        else
            spicy = false;

        Console.Write("Do you want to go to a fancy restaurant?(y/n):");
        response = Console.ReadLine();
        f = response[0];
        fancy = ((f == 'y') || (f == 'Y'));
        if (spicy)
        {     //Blocks
            if (fancy)
                Console.WriteLine("I suggest you go to Thai Garden Palace.");
            else
                Console.WriteLine("I suggest you to go to Alberto's Tacqueria.");
        }
        else
        {     //Blocks
            if (fancy)
                Console.WriteLine("I suggest you to go to Chez Paris.");
            else
                Console.WriteLine("I suggest you go to Joe's Diner.");
        }
    }
}


// Ans 2: Yes, both scenario are equivalent. In the first "if statement" is true or gives false value, it values false and in second condition the output eill be false else True.
// Ans 5: The if and else block are commented as a block in the code.
// Ans 6: The code is represented in nested if-else.