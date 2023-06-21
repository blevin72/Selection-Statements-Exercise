using System.Linq.Expressions;
using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {  //--------Exercise 1--------
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
                Console.WriteLine("You guessed it!!!");
            }

            //--------Exercise 2--------
            //Ask the user for their favorite school subject.
            //Store their answer in a variable
            //Pass the variable as the expression in a switch statement.
            //Create 5 different cases for different subjects. Each case will print the subject chosen and a custom message of your choosing.
            //Create a default case to handle any case not handled.

            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math: What happened to all the numbers in math?");
                    break;
                case "science":
                    Console.WriteLine("Science: I enjoyed dissecting the frogs.");
                    break;
                case "gym":
                    Console.WriteLine("Get your sweat on!");
                    break;
                case "history":
                    Console.WriteLine("Best lessons are the ones already learned.");
                    break;
                case "english":
                    Console.WriteLine("Reading helps me sleep at night instead of being on my phone.");
                    break;

            }
        }
    }
}
