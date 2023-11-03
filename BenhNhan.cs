using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    abstract  class BenhNhan
    {
        String maBenhNhan, hoTen;

        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }

        public void Nhap()
        {
            Console.WriteLine("nhập mã bệnh nhân: ");
            this.MaBenhNhan = Console.ReadLine();
            Console.WriteLine("nhập họ tên bệnh nhân  : ");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("alo");
        }
        public void Xuat()
        {
            Console.WriteLine("Danh sach benh nhan : \n {0} {1}",MaBenhNhan,hoTen);
            
        }
        public abstract double TinhVienPhi();
    }
}
