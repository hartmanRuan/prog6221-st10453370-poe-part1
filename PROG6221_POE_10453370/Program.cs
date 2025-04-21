
namespace PROG6221_POE_10453370
{
    using System;
    using System.Media;
    using System.Threading;
    using System.Threading.Tasks;
   

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
            Console.WriteLine("Hi " + userName + ". Lets start this off.") ;

            Responses chatbot = new Responses(userName);
            //Start looping for questions
            string userQuestion = "How are you";
            while (userQuestion!= "Bye")
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ask me a Cybersecurity related question or type 'Bye' to end the chat: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                userQuestion = Console.ReadLine();
                DelaySpeech(userQuestion);
                Console.WriteLine(chatbot.Response(userQuestion));
            }
            
            
            Console.ReadKey();
        }

        private static void DelaySpeech(string type)
        {
            string[] words = type.Split(' ');
            Task t = Task.Run(() =>
            {
                foreach (string word in words)
                {
                    foreach (char letter in word)
                    {
                        Thread.Sleep(210); //Numbers indicate how long the pause is of the chatbot before responding
                    }
                    Thread.Sleep(300);
                }
            });
            t.Wait();
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

    CodeGuru. 2018. Creating a typewriter effect in .NET, 19 September 2018. [Online]. Available at:
    https://www.codeguru.com/dotnet/creating-a-typewriter-effect-in-net/
    [Accessed 21/04/2025]
    */
}
