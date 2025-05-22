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
                                                    "Password",
                                                    "Phishing",
                                                    "Browsing",
                                                    "Downloads",
                                                    "Scam",
                                                    "Privacy",
                                                    "Thank you",
                                                    "Bye",
                                                    "Logo",
                                                    "Confused",
                                                    "Tell me more",
                                                    "Detail",
                                                    "Explain",
                                                    "Im interested in"
                                                    };

        //Array for all the responses
        private string[,] responseOutput1 =  { {"I am always well as i am robotic. I was hardcoded by my creator to always be well and positive", "I am doing good, thanks for asking. ", "A Chatbot like me... IM ALWAYS doing good. Thank you for asking" },
                                                    { "I am a Cybersecurity awareness bot that was built with the purpose of enlighting my users of the dangers around cybersecurity. I dont want my users to fall in the traps of threats!", "My purpose is to enlighten my users of the dangers and threats of the Cybersecurity world that are out there!", "My developers made me to try and raise awareness of cybersecurity by spreading facts about it." },
                                                    { "Ask me about anything cybersecurity related and i will do my best to answer your questions.", "I specialize in everything Cybersecurity related. Ask away!", "I was made to answer Cybersecurity related questions" },
                                                    { "I was created by a programmer, Ruan Hartman on 17 April 2025.", "Ruan Hartman created me as a solution for a task in 2025","I was made by a Computer and Information Science Student by the name of Ruan Hartman" },
                                                    { "Contact the following number for immediate support from a cybersecurity hotline: 011-202-3500", "Call our Hotline NOW: 011-241-3500", "Dont waste time! Call -> 011-410-3006" },
                                                    { "To ensure your password is up to standard, see that it complies with the following: \n\t\t -Minimum of 8 characters\n\t\t -Make use of both numbers and symbols\n\t\t -Use capital and lowercase letters\n\t\t -Make your password unrelated to you\nThe above criterea will give you a strong password.", "Your password should contain the following for it to be robust: \n\t-Numbers \n\t-Characters \n\t-Be longer than 8 spaces \n\t-Have no alignment with you as a person", "Your password should follow simple rules like having numbers, letter and symbols, it must also contain upper and lowercase letters."},
                                                    { "Phishing consits of you being under attack through emails or messages that pretend to be from big, legit companies...THEY ARE NOT! They use this to retrieve your personal data like passwords or credit card info. Do not fall for a trap like this. A reputable company will never ask for your password or banking info.", "Phishing is when a user is attacked with emails, that pretend to be big companies. They make users think they are from that company and use that to leverage their way with a user.", "Phishing summed up is a long stream of messages of people pretending to be a reputable source, trying to reach your sensitive data by you having to trust this 'BIG' company with your data" },
                                                    { "These are practices that protect you,as a user, from online threats. This can be anything from malware, to phishing. Safe browsing can be achieved by securing your browser, being educated of risks and using other security measures.", "When browsing, to remain safe, only download files from trusted sources, dont go on random websites. They can do you harm.", "Be careful of clicking on random websites and entering info into them."},
                                                    { "DO NOT DOWNLOAD FILES FROM RANDOM SITES!!! This is a way which malware can make it on your computer. Websites can disguise these files and when you download them, the malware gets on your computer without you noticing.", "Always be careful when downloading files. It is the easiest way your computer can become infected. Make sure you are downloading from trusted sources.", "Try to avoid opening and downloading of files from untrusted sources. They can do you and your computer harm"},
                                                    { "Always be aware of scammers. The best way of identifying one is to ask yourself if the offer they try and give you seems to good to be true. If it seems to good to be true, it likely is too good to be true.", "Scammers try to take advantage of a person by asking money for a product or service that doesnt exist. If they receive the payment, they dissappear with your money." , "A Scam is a person trying to get you to pay them for their services or products, but they never intend on actually giving you the service or product."},
                                                    { "Be aware of what data you enter and what you post and publish on certain social media apps, websites and register pages. Some companies use your data by selling it to other merketing companies.", "Try to not enter data on random websites. When they are asking for sensitive data, make sure that the website is secured and consider trying another way.", "Keep away from untrusted sites and be careful where you post, publish or enter your data on the internet. All that information can be used to do you harm"},
                                                    { "Not a problem. Feel free to ask me more questions", "Cool, im always here to answer more questions.", "Right-on! Keep the questions rolling if you have more."},
                                                    { "Goodbye", "Bye-Bye", "See you later"},
                                                    { ", I see you want to view my logo... :) ...Here is my logo :", ", I see you want to see my logo:" , ", here it is. Beautiful isnt it?"},
                                                    { "Invalid question detected. Please ask another question", "Invalid question detected. Please ask another question" ,"Damn, i could not understand your question... Please try again"} };
        
        int previousQuestion = 0;
        private string favourite = "";
        private bool fav = false;

        public Responses(string userName) : base(userName) 
        {

        }

        public override string Response(string questionRecieved)
        {
            //Get random number for random response
            Random rnd = new Random();
            int random = 0;
            for (int j = 0; j < 4; j++)
            {
                random = (rnd.Next(0, 3)); 
            }
            
            
            //Start loop
            for (int count = 0; count<19; )
            {
                if (questionRecieved.Equals(" "))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    return ("I didnt understand. Please try again " + userName );
                }
                else
                {
                    if (questionRecieved.ToLower().Contains(questionInput[count].ToLower()))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        count++;
                        if (questionRecieved.ToLower().Contains("logo"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            return userName + responseOutput1[count - 1, random] + "\n" + Open.OpenArt();
                        }
                        if (questionRecieved.ToLower().Contains("bye"))
                        {
                            return "Goodbye " + userName + ". Until next time!";
                        }
                        if (questionRecieved.ToLower().Contains("explain") || questionRecieved.ToLower().Contains("tell me more") || questionRecieved.ToLower().Contains("confused") || questionRecieved.ToLower().Contains("detail"))
                        {
                            
                            return Confusion(random, previousQuestion);
                        }
                        if (questionRecieved.ToLower().Contains("im interested in"))
                        {
                            fav = true;
                            return Memory(questionRecieved);
                        }
                        else
                        {
                            previousQuestion = count;
                            if (fav == true)
                            {
                                return "As you are interested in " + favourite + " ." + responseOutput1[count - 1, random];
                            }
                            else
                            {
                                Console.WriteLine(fav);
                                return userName + ",that is a great question, " + responseOutput1[count - 1, random];
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        count++;

                    }
                }
            }
            return "Sorry " + userName + " " + responseOutput1[14,random];
        }

        public string Confusion(int randomm, int prevCountt)
        {
            if (randomm == 0)
            {
                //Console.WriteLine(prevCountt-1);
                return "Sorry " + userName + " . Let me clarify for you: \n " + responseOutput1[prevCountt-1, randomm + 1];
            }
            else 
            if (randomm == 1)
            {
                //Console.WriteLine(prevCountt-1);
                return "Sorry " + userName + " . Let me explain more: \n " + responseOutput1[prevCountt-1, randomm + 1];
            }
            else
            if (randomm == 2)
            {
                //onsole.WriteLine(prevCountt-1);
                return "Sorry " + userName + " . Let me adjust my answer: \n " + responseOutput1[prevCountt-1, randomm -1];
            }
            else
            {
                return "I could not understand please try again.";
            }


               
        }

        public string Memory(string qReceived)
        {
            int count = 0;
            fav = true;
            favourite = qReceived.Remove(0,17);
            
            while (count < questionInput.Length)
            {
                if (questionInput[count].ToLower().Contains(favourite))
                {
                    return "Good to know " + userName + " . Ill keep the topic of " + favourite + " in mind for our future conversations.";
                }
                count++;
            }
            
            return "Good to know " + userName + " . Ill keep the topic of " + favourite + " in mind for future conversations.";
        }
    }
}
