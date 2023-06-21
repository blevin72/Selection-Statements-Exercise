using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {   //--------Exercise 1--------
           //Create an if-statement that if the guessed number is below the initial value, print out “too low”.
           //Create an else -if statement that if the number is higher than the initial value, print out “too high”.
           //Create an else statement that prints out some type of congratulations for guessing the correct number e.g. “You guessed it!!!”
            var r = new Random();
            var favNumber = r.Next(1, 3);

            Console.WriteLine("Guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }

            else
            {
                Console.WriteLine("You guessed it!!!")
            }
        }
    }
}
