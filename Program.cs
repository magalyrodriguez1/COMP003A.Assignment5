/*
 * Author: Magaly Rodriguez
 * Purpose: using methods and XML comments in an assignment
 * Course: COMP-003A
 */

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            PrintSeparator("Triangle Section");
            Console.WriteLine("Enter a single character: ");
            char inputCharacter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());
            
            IsoscelesTriangleBuilder(inputCharacter, size);
            PrintSeparator("Favorite Characters Section");
            
            CharacterInfo("Judy Hopps", 1992);
            CharacterInfo("Bree Van de Kamp", 1956);
            CharacterInfo("SpongeBob SquarePants", 1986);
            CharacterInfo("Chika Takami", 2003);
            CharacterInfo("Amy Santiago", 1983);
        }

        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// PrintSeparator() with no return value. calls method PrintSeparator() to print 50 '*'
        /// and allows for strings to be executed
        /// </summary>
        /// <param name="message"> the string name, to output a message</param>
        static void PrintSeparator(string message)
        {
            PrintSeparator();
            Console.WriteLine(message);
            PrintSeparator();
        }

        /// <summary>
        /// creates an isosceles triangle depending on user input and will output char depending on user input.
        /// made using nested for loops
        /// </summary>
        /// <param name="inputCharacter">character input</param>
        /// <param name="size"> size of the triangle input</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {   
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(inputCharacter);
                }
                Console.WriteLine();
            }

            for (int i = size; i >= 1; i--)
            {
               for (int j = i; j >= 1; j--)
                { 
                    Console.Write(inputCharacter);
                }
                Console.WriteLine();
            }         
           
        }
        
        /// <summary>
        /// a calculator that calculates character's birthday. subtracts the current year (2024) with the user input
        /// </summary>
        /// <param name="year">year input.</param>
        /// <returns>the age a character will turn</returns>
        static int AgeCalculator(int year)
        {
            return 2024 - year;
        }

        /// <summary>
        /// method that uses AgeCalculator(int year) method to output what age character will be turning.
        /// Method will output the character's name and the age character turns.
        /// </summary>
        /// <param name="name"> name input</param>
        /// <param name="birthYear"> birth year input</param>
        static void CharacterInfo(string name, int birthYear)
        {
            
            Console.WriteLine($"{name} is turning {AgeCalculator(birthYear)} this year!");

        }
    }
}
