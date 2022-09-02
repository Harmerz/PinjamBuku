using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinjamBuku
{
    
    internal class FindBook
    {
        private string Number;
        public FindBook()
        {
            Welcome welcome = new Welcome();
            bool check = false;
            string simpan = "";
            Console.WriteLine("Masukkan Nomor Buku");
            Number = Console.ReadLine();
            string[] ListBuku = File.ReadAllLines("../../ListBuku.txt");

            foreach (string isi in ListBuku)
            {
                string[] subs = isi.Split(',');
                foreach (var sub in subs)
                {
                    if (sub == Number)
                    {
                        check = true;
                        simpan = isi;
                        break;
                    }
                }
            }
            string enter;
            if (check)
            {
                string[] subs = simpan.Split(',');
             
                Console.WriteLine("\n############ Informasi Buku ############");
                Console.WriteLine($"Nomor Buku : {subs[0]}");
                Console.WriteLine($"Judul Buku : {subs[1]}");
                Console.WriteLine($"Tanggal Buku : {subs[2]}");
                Console.WriteLine($"Jenis Buku : {subs[3]}");
                enter = Console.ReadLine();
                welcome.WelcomeWriteline(false);
            }
            else
            {

                Console.WriteLine("Tidak ada Buku");
                enter = Console.ReadLine();
                welcome.WelcomeWriteline(false);
            }
            
        }
    }
}
