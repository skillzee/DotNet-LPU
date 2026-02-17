using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuesstions
{
    internal class Program
    {

        public static bool IsValid(string sentence)
        {
            foreach(var item in sentence)
            {

                ///string can only contain alphate and whitspace
                if (!Char.IsLetter(item) && !Char.IsWhiteSpace(item)) {
                    return false; 
                }
            }

            return true;

        }

        public static string WholeReversed(string[] sentence)
        {
            string final = "";
            foreach(var item in sentence)
            {
                string revWord = new String(item.Reverse().ToArray());
                final += revWord.ToString();
                final += " ";
            }

            return final.ToString();

        }

        public static string Reversed(string[] sentence)
        {

            string final = "";
            for(int i = sentence.Length - 1; i >= 0; i--)
            {
                final += sentence[i];
                final += ' ';
            }
            return final;

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the sentence: ");
            string sentence = Console.ReadLine();

            if (!IsValid(sentence))
            {
                Console.WriteLine("Invalid Sentence");
            }
            string[] sentenceArray = sentence.Split(' ');


            // If number of words in the sentence are not even all the letters sare reversed
            if (sentenceArray.Length % 2 !=0)
            {
                Console.WriteLine(WholeReversed(sentenceArray));

            }
            else
            {
                Console.WriteLine(Reversed(sentenceArray));
            }




        }
    }
}
