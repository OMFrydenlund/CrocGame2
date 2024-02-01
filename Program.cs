using static System.Formats.Asn1.AsnWriter;

namespace CrocGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Random numGen = new Random();

            while (true)
            {
                int leftNum = numGen.Next(1, 12);
                int rightNum = numGen.Next(1, 12);

                Console.WriteLine("Compare these two numbers with: < , > or =");
                Console.Write(leftNum + " _ " + rightNum + ": ");
                string userInput = Console.ReadLine();

                if (userInput == "<" && leftNum < rightNum || userInput == ">" && leftNum > rightNum || userInput == "=" && leftNum == rightNum)
                {
                    CorrectAnswerConfirmation();
                    score++;
                }
                else
                {
                    WrongAnswerConfirmation();
                    score--;
                }

                Console.WriteLine("Score: " + score);
                Console.WriteLine("\nWould you like to continue? (Y/N)");

                string continueChoice = Console.ReadLine().ToUpper();
                if (continueChoice != "Y")
                {
                    break;
                }

                Console.Clear();
            }
        }

        private static void CorrectAnswerConfirmation()
        {
            Console.WriteLine("\n\nCorrect! You are awarded one point.");
        }

        private static void WrongAnswerConfirmation()
        {
            Console.WriteLine("\n\nNot the right answer, try again...");

        }
    }
}
