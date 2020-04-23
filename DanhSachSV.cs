using System;
using System.Collections.Generic;
using System.Text;

namespace c3_b6
{
    class DanhSachSV
    {
        private int n;
        private SinhVien[] DS;

        public void nhap()
        {
            Console.WriteLine("Hay nhap so sinh vien trong danh sach: ");
            n = Convert.ToInt32(Console.ReadLine());

            DS = new SinhVien[n];

            for(int i=0;i<n;i++)
            {
                Console.WriteLine("hay nhap thong tin cho SV: " + i);
                DS[i] = new SinhVien();
                DS[i].nhap();
            }    
        }
        public void xuat ()
        {
            if(DS !=null && n>0)
            {
                for (int i=0; i<n;i++)
                {
                    DS[i].xuat();
                }
            }
        }

        public void sapxep()
        {
            for(int i=0;i<n-1;i++)
                for(int j=i+1;j<n;j++)
                {
                    if (string.Compare(DS[i].MaSV, DS[j].MaSV , true)>0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }
                     
                }
        }
    }
}
