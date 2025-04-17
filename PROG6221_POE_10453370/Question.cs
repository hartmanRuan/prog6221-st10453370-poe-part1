using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_10453370
{
    class Question
    {

        public Question(string questions)
        {
            if (questions.Contains("How are you"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("I am always well as i am robotic. I was hardcoded by my creator to always be well and positive. Thanks for asking " + User.);
            } else
            if (questions.Contains("What is your purpose"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("I am a Cybersecurity awareness bot that was built with the purpose of enlighting my users of the dangers around cybersecurity. I dont want my users to fall in the traps of threats!");
            } else
            if (questions.Contains("What can i ask you about"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ask me about anything cybersecurity related and i will do my best to answer your questions.");
            } else
            if (questions.Contains("Who created you"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("I was created by a programmer, Ruan Hartman on 17 April 2025.");
            } else
            if (questions.Contains("Emergency"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Contact the following number for immediate support from a cybersecurity hotline: 011-202-3500");
            } else
            if (questions.Contains("Password safety"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("To ensure your password is up to standard, see that it complies with the following: \n\t\t -Minimum of 8 characters\n\t\t -Make use of both numbers and symbols\n\t\t -Use capital and lowercase letters\n\t\t -Make your password unrelated to you\nThe above criterea will give you a strong password.");
            }
            else
            if (questions.Contains("Phishing"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Phishing consits of you being under attack through emails or messages that pretend to be from big, legit companies...THEY ARE NOT! They use this to retrieve your personal data like passwords or credit card info. Do not fall for a trap like this. A reputable company will never ask for your password or banking info. ");
            }
            else
            if (questions.Contains("Safe browsing"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("These are practices that protect you,as a user, from online threats. This can be anything from malware, to phishing. Safe browsing can be achieved by securing your browser, being educated of risks and using other security measures.");
            }
            else
            if (questions.Contains("Download files"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DO NOT DOWNLOAD FILES FROM RANDOM SITES!!! This is a way which malware can make it on your computer. Websites can disguise these files and when you download them, the malware gets on your computer without you noticing.");
            }
            else
            if (questions.Contains("Thank you"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Not a problem. Feel free to ask me more questions");
            }
            else
            if (questions.Contains("Bye"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid question detected. Please ask another question");
            }
        }




    }
}
