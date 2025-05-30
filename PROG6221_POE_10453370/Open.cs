﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_10453370
{
    class Open
    {
        public static string OpenArt()//-----------------------------------------------------------------------
        {
            //Ascii Art
            
            return("    #############     \r\n" + //\r = goes back to start of current line
                "    ##         ##     \r\n" +
                "    #  ~~   ~~  #    \r\n" +
                "    # (-)   (-) #    \r\n" +
                "    (     ^     )    \r\n " +
                "    |         |    \r\n" +
                "     |  {===}  |    \r\n" +
                "      \\       /      \r\n" +
                "     /  -----  \\    \r\n" +
                "  ---  |%\\ /%|  ---   \r\n" +
                " /     |%%%%%|     \\   \r\n" +
                "       |%/ \\%|       \r\n");

        }
        public static void OpenSound()
        { 
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

                Console.WriteLine("Hi, i am a Cybersecurity chatbot. What is your Name?\n\t\t\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;



            }


        }

        public static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("##      ## ######## ##        ######   #######  ##     ## ######## \r\n" +
                              "##  ##  ## ##       ##       ##    ## ##     ## ###   ### ##       \r\n" +
                              "##  ##  ## ##       ##       ##       ##     ## #### #### ##       \r\n" +
                              "##  ##  ## ######   ##       ##       ##     ## ## ### ## ######   \r\n" +
                              "##  ##  ## ##       ##       ##       ##     ## ##     ## ##       \r\n" +
                              "##  ##  ## ##       ##       ##    ## ##     ## ##     ## ##       \r\n" +
                              " ###  ###  ######## ########  ######   #######  ##     ## ######## ");
           
            Console.BackgroundColor = ConsoleColor.Black;
        }
        }
}
