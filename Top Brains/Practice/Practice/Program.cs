using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {

        public static void PrintList<T>(IEnumerable<T> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsPal(string str)
        {
            string rev = new string(str.Reverse().ToArray());

            if(str == rev)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string str = "aba";

            List<int> list = new List<int>();
            list.Add(3);
            list.Add(78);
            list.Add(7);
            list.Sort();

            char[] stringArray = str.ToArray();
            Array.Sort(stringArray);
            //Console.WriteLine(stringArray);
            //int index = Array.BinarySearch(stringArray, 'a');
            //Console.WriteLine(index);


            //PrintList(stringArray);

            string name = "Parth";
            string rev = "";
            for(int i = name.Length-1; i>=0; i--)
            {
                rev += name[i];
            }
            string revnew = new string(name.Reverse().ToArray());

            //Console.WriteLine(revnew);



            //if (IsPal(str))
            //{
            //    Console.WriteLine("Is a palindrome");
            //}



            string vowels = "aeiouAEIOU";
            int vowelsCount = 0;
            int consonantCount = 0;
            foreach(var item in str)
            {
                if (Char.IsLetter(item))
                {
                    if (vowels.Contains(item))
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            //Console.WriteLine($"Vowels: {vowelsCount}");
            //Console.WriteLine($"Consonats: {consonantCount}");




            // Remove Duplicates

            string dup = "Programming";
            HashSet<char> set = new HashSet<char>();
            foreach(var item in dup)
            {
                set.Add(item);
            }

            string nodup = "";
            foreach(var item in set)
            {
                nodup+= item;
            }
            //Console.WriteLine(nodup);



            //Check Anagram

            string a = "listen";
            string b = "silentsd";

            char[] arra = a.ToCharArray();
            Array.Sort(arra);
            char[] arrb = b.ToArray();
            Array.Sort(arrb);
            string sorteda = new string(arra);
            string sortedb = new string(arrb);
            if(sorteda == sortedb)
            {
                //Console.WriteLine("Is Anagram");
            }


            string sentence = "I love dotnet programming";
            string[] strArr = sentence.Split(' ');
            //Console.WriteLine(strArr.Length);

            //Replace Multiple Spaces with Single Space
            string multiSpace = "I   love  dotnet";

            string[] multiArray = multiSpace.Split(' ');
            string output = "";
            foreach(var item in multiArray)
            {
                if(String.IsNullOrWhiteSpace(item))
                {
                    continue;
                }
                else
                {
                    output+= item;
                    output += " ";
                }
            }
            //PrintList(multiArray);
            Console.WriteLine(output);


            //Find freq

            string repeated = "aabbccc";
            Dictionary<char , int> map = new Dictionary<char, int>();
            foreach (var item in repeated)
            {

                if (!map.ContainsKey(item))
                {
                    map[item] = 1;
                }
                else
                {
                    map[item] += 1;
                }

            }

            //foreach(var item in map)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}



            //LongestWord
            string word = "I love programming in dotnet";
            string[] wordArray = word.Split(' ');
            int maxi = Int32.MinValue;
            string longest = "";


            foreach (var item in wordArray)
            {
                if(item.Length > maxi)
                {
                    maxi = item.Length;
                    longest = item;
                }

            }

            Console.WriteLine(longest);


            //Reverse each word in a sentence but keep sentence structure same.

            string word1 = "I love dotnet";
            string[] word1Arr = word1.Split(' ');
            string newWord = "";
            for(int i = 0; i<word1Arr.Length; i++)
            {
                string op = new string(word1Arr[i].Reverse().ToArray());
                newWord += op;
                newWord += " ";
            }
            //Console.WriteLine(newWord);




            List<string> words = new List<string>
            {
                "cat",
                "dog",
                "elephant",
                "bat",
                "lion"
            };

            var grouped = words.GroupBy(w => w.Length);
            foreach (var group in grouped)
            {
                Console.WriteLine("Length: " + group.Key);

                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }











        }
    }
}
