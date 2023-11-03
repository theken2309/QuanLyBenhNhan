using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    internal class BenhNhanBHYT:BenhNhan,ITIENAN
    {
        int soBHYT, ngayNamVienBHYT;

        public BenhNhanBHYT()
        {

        }
        public BenhNhanBHYT(int soBHYT, int ngayNamVienBHYT)
        {
            this.soBHYT = soBHYT;
            this.ngayNamVienBHYT = ngayNamVienBHYT;
        }


        public int SoBHYT { get => soBHYT; set => soBHYT = value; }
        public int NgayNamVienBHYT { get => ngayNamVienBHYT; set => ngayNamVienBHYT = value; }

        public double TinhTienAn()
        {
            return NgayNamVienBHYT * 25000;
        }

        public override double TinhVienPhi()
        {
            return (NgayNamVienBHYT * 50000) + TinhTienAn();
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap so bao hiem y te : ");
            this.soBHYT = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so ngay nam vien :");
            this.ngayNamVienBHYT = int.Parse(Console.ReadLine());
        }

        
        //public override void Nhap()
        //{
        //    Console.WriteLine("nhap so bao hiem y te : ");
        //    this.soBHYT = int.Parse(Console.ReadLine());
        //    this.NgayNamVienBHYT = int.Parse(Console.ReadLine());
        //}


    }
}
