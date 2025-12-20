using System;

namespace ConditionalAssignments;

public class Vowel
{

    public static void VowelMain()
    {
        System.Console.WriteLine("Enter the character");
        char ch = Convert.ToChar(Console.Read());
        
        switch (Char.ToLower(ch))
        {
            case 'a':
                System.Console.WriteLine("This is a vowel");
                break;
            case 'e':
                System.Console.WriteLine("This is a vowel");
                break;
            case 'i':
                System.Console.WriteLine("This is a vowel");
                break;
            case 'o':
                System.Console.WriteLine("This is a vowel");
                break;
            case 'u':
                System.Console.WriteLine("This is a vowel");
                break;
            default:
                System.Console.WriteLine("This is a consonant");
                break;


        }
    }

}
