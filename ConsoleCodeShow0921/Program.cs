using System;
using System.Text;

namespace ConsoleCodeShow0921
{
    class Program
    {

        /*

            MVC - Design patten
            Model - Store data 
            View - Display data
            Control - Controlls the flow

        */
        static void Main(string[] args)
        {
            string texts = "asd asdasd asdasdasd asdasdasd";

            string[] textArray = texts.Split(' ');

            foreach (var item in textArray)
            {
                Console.WriteLine(item);
            }

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
