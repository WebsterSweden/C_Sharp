using System;
using System.Collections.Generic;
using System.Text;

namespace Object6
{
    class User
    //public class User
    {
        public string UserName { get; set; } = "UserName Default Value";
        //public string UserName { get; set; }

        public void UserMethodOne()
        {
            UserName = "UserNameMethodOne";

            Console.WriteLine($"{UserName}");
        }
    }
}
