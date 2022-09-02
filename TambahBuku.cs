using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinjamBuku
{
    internal class TambahBuku
    {
        private string Number;
        private string NameBook;
        private string DescriptionBook;
        private char addBook;
        private void TambahkanBuku(string Number, string NameBook, string DescriptionBook, bool checkInput)
        {
            Welcome welcome = new Welcome();
            TambahBuku buku = new TambahBuku();

            Console.Clear();
            if (checkInput)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Input!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("############ Informasi Buku ############");
            DateTime today = DateTime.Today;
            Console.WriteLine($"Nomor Buku : {Number}");
            Console.WriteLine($"Judul Buku : {NameBook}");
            Console.WriteLine($"Jenis Buku : {DescriptionBook}");
            Console.Write("Tanggal Ditambahkan : ");
            Console.WriteLine(today.ToString("dd/MM/yyyy"));
            Console.WriteLine("\nTambahkan Buku ini?(Y/N)");
            addBook = (char)Console.Read();
            string enter = Console.ReadLine();
            if (addBook == 'Y' || addBook == 'y')
            {
                string[] ListBuku = File.ReadAllLines("ListBuku.txt");
                List<string> list = new List<string>();
                string add = Number + "," + NameBook + "," + today.ToString("dd/MM/yyyy") + "," + DescriptionBook; ;
                foreach (string isi in ListBuku)
                {
                    list.Add(isi);
                }
                list.Add(add);
                list.Sort();
                String[] str = list.ToArray();
                File.WriteAllLines("../../ListBuku.txt", str);
                welcome.WelcomeWriteline(false);
            }
            else if (addBook == 'N' || addBook == 'n')
            {
                welcome.WelcomeWriteline(false);
            }
            else
            {
                
                buku.TambahkanBuku(Number, NameBook, DescriptionBook, true);
                
            }
        }
        public void DeskripsiBuku()
        {

            TambahBuku buku = new TambahBuku();
            
            //TODO read a Book description
            Console.WriteLine("############ Tambahkan Buku ############");
            Console.WriteLine("Nomor Buku :");
            Number = Console.ReadLine();
            Console.WriteLine("Judul Buku :");
            NameBook = Console.ReadLine();
            Console.WriteLine("Jenis Buku :");
            DescriptionBook = Console.ReadLine();
            buku.TambahkanBuku(Number, NameBook, DescriptionBook, false);
            
        }

        
    }
}
