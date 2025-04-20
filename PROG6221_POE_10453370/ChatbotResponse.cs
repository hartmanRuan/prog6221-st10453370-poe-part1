using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_10453370
{
    abstract class ChatbotResponse
    {
        protected string userName;//When private, other class cannot access for personalized responses

        //CONSTRUCTOR
        public ChatbotResponse()
        {
            userName = " ";
        }
        public ChatbotResponse(string user)
        {
            this.userName = user;
        }

        public abstract string Response(string question);
    }
}
