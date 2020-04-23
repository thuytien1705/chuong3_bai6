using System;

namespace c3_b6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("thuc hanh lam viec voi doi tuong sv");
            DanhSachSV sv1 = new DanhSachSV();
            sv1.nhap();
            sv1.xuat();
            sv1.sapxep();
            sv1.xuat();

            Console.ReadLine();

        }
    }
}
