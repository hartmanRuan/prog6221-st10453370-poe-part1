
namespace PROG6221_POE_10453370
{
    using System;
    using System.Media;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string art =Open.OpenArt();
            Console.WriteLine(art);
            Open.OpenSound();
            //Get Username
            Console.ForegroundColor = ConsoleColor.Blue;
            string userName = Console.ReadLine();
            //Welcome messages
            Open.WelcomeMessage();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi " + userName + ". It is nice to meet you.") ;

            Responses chatbot = new Responses(userName);
            //Start looping for questions
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

    /*REFERENCE LIST
     ASCII Art Archive. 2025. A large collection of ascii art drawings of faces and other ralated people, 2025. [Online].
    Available at:
    https://www.asciiart.eu/people/faces
    [Accessed 19/04/2025]

    AIVOICEGENERATOR.COM. 2025. AI Voice Generator free, 2025. [Online]. Available at: https://aivoicegenerator.com/
    [Accessed 19/04/2025]

    W3Schools. 2025. C# Abstraction, 2025. [Online]. Available at: https://www.w3schools.com/cs/cs_abstract.php
    [Accessed 20/04/2025]

    PatorJK. 2025. Text To Ascii Art Generator, 2025. [Online]. Available at:
    https://patorjk.com/software/taag/#p=display&f=Banner3&t=Welcome
    [Accessed 20/04/2025]
    */
}
