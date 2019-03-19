using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengeset nilai properties objek saya dan kamu
            saya.Nim = "18.11.6666";
            saya.Nama = "Tejo";
            saya.Ipk = 4.00f;

            kamu.Nim = "18.11.9999";
            kamu.Nama = "Bambhank";
            kamu.Ipk = 3.85f;

            //memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
