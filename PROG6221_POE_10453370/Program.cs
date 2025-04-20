
namespace PROG6221_POE_10453370
{
    using System;
    using System.Media;
    internal class Program
    {
        static void Main(string[] args)
        {

            string art =Open.OpenArt();
            Console.WriteLine(art);
            Open.OpenSound();
            Console.ForegroundColor = ConsoleColor.Blue;
            string userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi " + userName + ". It is nice to meet you.") ;

            Responses chatbot = new Responses(userName);

            string userQuestion = "How are you";
            while (userQuestion!= "Bye")
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ask me a Cybersecurity related question or type 'Bye' to end the chat: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                userQuestion = Console.ReadLine();
                Console.WriteLine(chatbot.Response(userQuestion));
            }

            
            Console.ReadKey();
        }
    }
}
