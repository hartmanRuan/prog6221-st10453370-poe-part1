
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

            Console.ReadKey();
        }
    }
}
