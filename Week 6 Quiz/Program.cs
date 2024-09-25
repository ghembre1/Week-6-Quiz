using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_Quiz
{
    internal class Program
    {
        public static void ReverseString(string input)
        {
            if (input == null)
                Console.WriteLine("Input is not valid");
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            Console.WriteLine(chars);
            //return new string(chars);
        }

        public static void CountVowels(string input)
        {
           
            int count = 0;
            foreach (char c in input.ToUpper()) {
                
                if ("ouiea".ToUpper().Contains(c))
                    count++; 
            
            }

            Console.WriteLine(count);
        }

        public static void IsPalindrome(string input)
        {
            if (input == null)
                Console.WriteLine("Input is not valid");

        }
        static void Main(string[] args)
        {
            int number = 1;

            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Reverse String");
                Console.WriteLine("2. Count Vowels");
                Console.WriteLine("3. Is Palindrome");


                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your string?");
                string aString = Console.ReadLine();


                switch (number)
                {
                    case 1:
                        {

                            ReverseString(aString);
                            break;
                        }

                    case 2:
                        CountVowels(aString);
                        break;

                    case 3:
                        IsPalindrome(aString);
                        break;
                }
            } while (number != 0);



            Console.ReadKey();
        }
    }
}
