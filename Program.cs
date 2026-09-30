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
        //public void setData(string nama, string kesehatan, string senjata, int totalSenjata, int kekuatan)
        //{
        //    this.nama = nama;
        //    this.kesehatan = kesehatan;
        //    this.senjata = senjata;
        //    this.totalSenjata = totalSenjata;
        //    this.kekuatan = kekuatan;
        //}


        //public void getData()
        //{
        //    Console.WriteLine(nama);
        //    Console.WriteLine(kesehatan);
        //    Console.WriteLine(senjata);
        //    Console.WriteLine(totalSenjata);
        //    Console.WriteLine(kekuatan);
        //}
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


                //player1.nama = ("Fiqri Aqias");
                //player1.kesehatan = ("Sehat");
                //player1.senjata = ("Demon Sword");
                //List<Karakter> daftarMC = new List<Karakter>(); //array penyimpan data

                //Karakter player1 = new Karakter();
                //player1.setData("Fiqri", "Kesehatan: Inni Bin Sehaati Alhamdulillah", "Senjata: Karambit", 2, 100);
                ////player1.getData();

                //Karakter player2 = new Karakter();
                //player2.setData("Aqias", "Kesehatan: Inni Amrod", "Senjata: Tangan Kosong", 0, 50);
                ////player2.getData();

                //List<Karakter> daftarMusuh = new List<Karakter>();
                //Karakter enemy = new Karakter();
                //enemy.setData("Musuh: Alucard", "Kekebalan Tubuh", "Senjata: Demon Sword", 1, 99);
                //enemy.getData();

                //Karakter enemy2 = new Karakter();
                //enemy2.setData("Musuh: Dracula", "Kerentanan Tubuh", "Senjata: Drows Nomed", 2, 1);
                //enemy2.getData();

                //daftarMC.Add(player1);
                //daftarMC.Add(player2);

                ////menampilkan data dari array, foreach
                //foreach(Karakter player in daftarMC)
                //{
                //    player.getData();
        }
            }
}