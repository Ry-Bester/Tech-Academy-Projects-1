using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ryan";
            string mname = "c";
            string lname = "bester";

            lname = lname.ToUpper();
            Console.WriteLine(name + mname + lname);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello I'm Ryan ");
            sb.Append("Do you know what time it is? ");
            sb.Append("Dont bother answering i was just curious. ");
            sb.Append("Well... it was nice talking to you. see you later. ");
            sb.Append("Bye Bye now! ");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
