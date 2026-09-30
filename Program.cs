//16/09/26

using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace KerangkaGame
{
    class Karakter
    {
        public int totalSenjata, kekuatan;

        //enskapsulasi
        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }

        public Karakter(string nama, int kesehatan, int senjata) //Membuat constructor
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }

        public void Serang(Karakter target)
        {
            Console.WriteLine("==> Mulai Serangan");
            target.TerimaSerangan(this.senjata);
        }

        public void TerimaSerangan(int jumlahSerangan)
        {
            kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama}, Diserang dengan {jumlahSerangan}," +
                $" Sisa kesehatan {kesehatan}");
        }
      
        public void getData()
        {
            Console.WriteLine($"Karakter {nama}, KesehatanMu {kesehatan}, Senjata {senjata} ");
        }
    }
        class MainProgram
        {
            static void Main(string[] args)
            {
                Karakter player1 = new Karakter("Fiqri", 100, 50); //membuat objek
                
                Karakter musuh = new Karakter("Iblis", 99, 51);

                //interaksi
                player1.Serang(musuh);

                player1.getData();


             
        }
            }
}