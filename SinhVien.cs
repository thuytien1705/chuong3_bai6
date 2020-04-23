using System;
using System.Collections.Generic;
using System.Text;

namespace c3_b6
{
    class SinhVien
    {
        private string _TenSV;
        private string _MaSV;
        private int _NamSinh;
      
        private float _DiemLT, _DiemCSDL, _DiemTB;

        public SinhVien()
        {
            _TenSV = "";
            _MaSV = "";
            _NamSinh = 1900;
           
            _DiemLT = 0;
            _DiemCSDL = 0;
            _DiemTB = 0;
        }

        public string TenSV
        {
            get { return _TenSV; }
            set { _TenSV = value; }
        }

        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }

        public int NamSinh
        {
            get { return _NamSinh; }
            set { _NamSinh = value; }
        }

        public float DiemLT
        {
            get { return _DiemLT; }
            set { _DiemLT = value; }
        }

        public float DiemCSDL
        {
            get { return _DiemCSDL; }
            set { _DiemCSDL = value;
                _DiemTB = (_DiemLT + _DiemCSDL) / 2;
            }
        }

        public float DiemTB
        {
            get { return _DiemTB; }
        }

        public void nhap()
        {
            Console.WriteLine("hay nhap ten sv");
            TenSV = Console.ReadLine();
            Console.WriteLine("hay nhap ma sv");
            MaSV = Console.ReadLine();
            Console.WriteLine("hay nhap nam sinh");
            NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("hay nhap diem lap trinh");
            DiemLT = float.Parse( Console.ReadLine());
            Console.WriteLine("hay nhap diem csdl");
            DiemCSDL = float.Parse(Console.ReadLine());
            
        }
        public void xuat()
        {
            Console.WriteLine("ma cua sinh vien la: " + MaSV);
            Console.WriteLine("ten cua sinh vien la: " + TenSV);
            Console.WriteLine("nam sinh la: " + NamSinh);
            Console.WriteLine("diem LT la: " + DiemLT);
            Console.WriteLine("diem csdl la: " + DiemCSDL);
            Console.WriteLine("diem TB la: " + DiemTB);
        }

    }
}
