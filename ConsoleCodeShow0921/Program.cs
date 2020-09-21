using System;
using System.Text;

namespace ConsoleCodeShow0921
{
    class Program
    {

        /*

        */
        static void Main(string[] args)
        {
            



        }// end main

        static string GetRandomWord()
        {
            string[] wordArray = { "Cat", "Dog", "Pump", "coding" };

            Random random = new Random();

            return wordArray[random.Next(wordArray.Length)]; // 0-2
        }

        static void ExStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();

            Console.WriteLine("Check: " + CheckForLetter(stringBuilder, 'd'));
        }

        static bool CheckForLetter(StringBuilder stringBuilder, char letter)
        {
            string text = stringBuilder.ToString();

            if (String.IsNullOrEmpty(text))
            {

                if (text.IndexOf(letter) == -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            return false;
        }

    }// end program
}// end namespace
