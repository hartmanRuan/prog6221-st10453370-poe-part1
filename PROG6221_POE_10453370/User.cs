using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PROG6221_POE_10453370
{
    class User
    {   //Variables/Attributes
        private string nameUser { get; set; }
        

        public string GetNameUser()//---------------------------------------------------------------------------------------------
        {
            return nameUser;
        }

        public User()
        {
            nameUser = Console.ReadLine() ;
            
        }



        public static void ProgramOpen()//-----------------------------------------------------------------------
        {
            //Ascii Art
            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Console.Write("    #############     \r\n    ##         ##     \r\n    #  ~~   ~~  #    \r\n    #  ()   ()  #    \r\n    (     ^     )    \r\n     |         |    \r\n     |  {===}  |    \r\n      \\       /      \r\n     /  -----  \\    \r\n  ---  |%\\ /%|  ---   \r\n /     |%%%%%|     \\   \r\n       |%/ \\%|       \r\n");
            //Sound with welcome message
            try
            {
                SoundPlayer player = new SoundPlayer("AIVoiceGenerator_com_10-04-2025T13_48_8_ Matthew.wav");
                player.Load();
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not play sound:");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                
                Console.WriteLine("Hi, i am a Cybersecurity chatbot. What is your Name?");
                Console.ForegroundColor = ConsoleColor.Blue;
                
                

            }
        }
    }
}
