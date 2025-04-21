using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_10453370
{
    class Responses: ChatbotResponse
    {
        //Array for all the questions
        private string[] questionInput =  { "How are you",
                                                    "What is your purpose",
                                                    "What can i ask you about",
                                                    "Who created you",
                                                    "Emergency",
                                                    "Password safety",
                                                    "Phishing",
                                                    "Safe Browsing",
                                                    "Download files",
                                                    "Thank you",
                                                    "Bye",
                                                    "Logo" };

        //Array for all the responses
        private string[] responseOutput =  { "I am always well as i am robotic. I was hardcoded by my creator to always be well and positive",
                                                    "I am a Cybersecurity awareness bot that was built with the purpose of enlighting my users of the dangers around cybersecurity. I dont want my users to fall in the traps of threats!",
                                                    "Ask me about anything cybersecurity related and i will do my best to answer your questions.",
                                                    "I was created by a programmer, Ruan Hartman on 17 April 2025.",
                                                    "Contact the following number for immediate support from a cybersecurity hotline: 011-202-3500",
                                                    "To ensure your password is up to standard, see that it complies with the following: \n\t\t -Minimum of 8 characters\n\t\t -Make use of both numbers and symbols\n\t\t -Use capital and lowercase letters\n\t\t -Make your password unrelated to you\nThe above criterea will give you a strong password.",
                                                    "Phishing consits of you being under attack through emails or messages that pretend to be from big, legit companies...THEY ARE NOT! They use this to retrieve your personal data like passwords or credit card info. Do not fall for a trap like this. A reputable company will never ask for your password or banking info.",
                                                    "These are practices that protect you,as a user, from online threats. This can be anything from malware, to phishing. Safe browsing can be achieved by securing your browser, being educated of risks and using other security measures.",
                                                    "DO NOT DOWNLOAD FILES FROM RANDOM SITES!!! This is a way which malware can make it on your computer. Websites can disguise these files and when you download them, the malware gets on your computer without you noticing.",
                                                    "Not a problem. Feel free to ask me more questions",
                                                    "Goodbye",
                                                    "I see you want to view my logo... :) ...Here is my logo :",
                                                    "Invalid question detected. Please ask another question" };


        public Responses(string userName) : base(userName) 
        {

        }

        public override string Response(string questionRecieved)
        {
           
            for (int count = 0; count<12; )
            {
                if (questionInput[count].Contains(questionRecieved))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    count++;
                    if (questionRecieved.Equals("Logo"))
                    {
                        return userName + responseOutput[count - 1] + "\n" + Open.OpenArt();
                    }
                    if (questionRecieved.Equals("Bye"))
                    {
                        return "Goodbye " + userName + ". Until next time!";
                    }
                    return userName + ",that is a great question, " + responseOutput[count-1];
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    count++;

                }
            }
            return "Sorry " + userName + " " + responseOutput[12];
        }
    }
}
