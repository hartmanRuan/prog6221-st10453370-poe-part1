
namespace PROG6221_POE_10453370
{
    using System;
    using System.Media;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("_______  ______    _______  __    _  ___   _  __   __ \r\n|       ||    _ |  |   _   ||  |  | ||   | | ||  | |  |\r\n|    ___||   | ||  |  |_|  ||   |_| ||   |_| ||  |_|  |\r\n|   |___ |   |_||_ |       ||       ||      _||       |\r\n|    ___||    __  ||       ||  _    ||     |_ |_     _|\r\n|   |    |   |  | ||   _   || | |   ||    _  |  |   |  \r\n|___|    |___|  |_||__| |__||_|  |__||___| |_|  |___| \r\n\r\n");
            Console.Write("    #############     \r\n    ##         ##     \r\n    #  ~~   ~~  #    \r\n    #  ()   ()  #    \r\n    (     ^     )    \r\n     |         |    \r\n     |  {===}  |    \r\n      \\       /      \r\n     /  -----  \\    \r\n  ---  |%\\ /%|  ---   \r\n /     |%%%%%|     \\   \r\n       |%/ \\%|       \r\n\n\n");
            try
            {
                SoundPlayer player = new SoundPlayer("AIVoiceGenerator_com_10-04-2025T13_48_8_ Matthew.wav");
                player.Load();       
                player.PlaySync();   
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Could not play sound:");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Ask me a Question about CYBERSECURTIY: ");
            }
            Console.ReadKey();
        }
    }
}
