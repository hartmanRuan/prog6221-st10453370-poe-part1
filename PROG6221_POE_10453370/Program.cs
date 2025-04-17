
namespace PROG6221_POE_10453370
{
    using System;
    using System.Media;
    internal class Program
    {
        static void Main(string[] args)
        {

            User.ProgramOpen();
            
            User user = new User();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello " + user.GetNameUser() + ", its nice to meet you!");


            string userQuestion = " ";
            while (userQuestion!= "Bye")
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ask me a Cybersecurity related question or type 'Stop' to end the chat: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                userQuestion = Console.ReadLine();
                Question question = new Question(userQuestion);
            }

            
            Console.ReadKey();
        }
    }
}
