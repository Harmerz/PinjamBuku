using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinjamBuku
{
    internal class Welcome
    {
        public int input;
        public void WelcomeWriteline(bool checkInput)
        {
            Welcome welcome = new Welcome();
            Console.Clear();
            
            if ((checkInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Input");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("");
            }
            Console.WriteLine("############ Welcome ############");
            Console.WriteLine("#\t\t\t\t#");
            Console.WriteLine("#\t1.List Buku\t\t#");
            Console.WriteLine("#\t2.Cari Buku\t\t#");
            Console.WriteLine("#\t9.Exit\t\t\t#");
            Console.WriteLine("#\t\t\t\t#");
            Console.WriteLine("#################################\n");
            Console.Write("Select : ");

            //TODO input welcome
            welcome.input = Console.Read();
            if (welcome.input == 49)
            {
                string enter = Console.ReadLine();
                Console.Clear();
                ListBuku listBuku = new ListBuku();

            }
            else if (welcome.input == 50)
            {
                string enter = Console.ReadLine();
                Console.Clear();
                FindBook Findbuku = new FindBook();
            }
            else if (welcome.input == 57)
            {
                string enter = Console.ReadLine();
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                welcome.WelcomeWriteline(true);
            }
        }
    }
}
