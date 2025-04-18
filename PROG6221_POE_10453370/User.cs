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
            nameUser = Console.ReadLine();
        }


    }
}
