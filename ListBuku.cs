using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PinjamBuku
{
    internal class ListBuku
    {
        private char tambahBuku;
        public ListBuku()
        {
            Welcome welcome = new Welcome();

            Console.WriteLine("########################################### List Buku ###########################################");
            Console.WriteLine("#\tNomor Buku\t#\tJudul   \t#\tTanggal  \t#\tJenis Buku\t#");


            // Read a text file line by line.  
            string[] ListBuku = File.ReadAllLines("../../ListBuku.txt");

            foreach (string isi in ListBuku)
            {
                string[] subs = isi.Split(',');
                foreach (var sub in subs)
                {
                    string tampil;
                    if (sub.Length > 20)
                    {
                        tampil = sub.Substring(0, 20);
                    }
                    else
                    {
                        tampil = sub;
                    }
                    
                    Console.Write($"{tampil}");
                    if (tampil.Length > 15)
                    {
                        Console.Write("\t");
                    }
                    else if (tampil.Length > 7)
                    {
                        Console.Write("\t\t");
                    }
                    else
                    {
                        Console.Write("\t\t\t");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nIngin menambahkan Buku? (Y/N)");
            tambahBuku = (char)Console.Read();
            string enter = Console.ReadLine();
            if (tambahBuku == 'Y' || tambahBuku == 'y')
            {
                TambahBuku tambahBuku = new TambahBuku();
                tambahBuku.DeskripsiBuku();

            }
            else if(tambahBuku == 'N' || tambahBuku == 'n')
            {
                welcome.WelcomeWriteline(false);
            }
            else
            {
                welcome.WelcomeWriteline(true);
            }
        }
    }
}
