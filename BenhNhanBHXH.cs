using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    internal class BenhNhanBHXH : BenhNhan, ITIENAN
    {
        int soBHXH, ngayNamVienBHXH;
        public BenhNhanBHXH()
        {
        }

        public BenhNhanBHXH(int soBHXH, int ngayNamVienBHXH)
        {
            this.soBHXH = soBHXH;
            this.ngayNamVienBHXH = ngayNamVienBHXH;
        }

        public double TinhTienAn()
        {
            return 30000 * ngayNamVienBHXH;
        }

        public override double TinhVienPhi()
        {
            return (ngayNamVienBHXH*70000)+TinhTienAn();
        }
        public virtual void Nhap()
        {
            Console.WriteLine("nhap bao hiem xa hoi : ");
            soBHXH = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Benh nhan co BHXH : {0} \n so ngay nam vien la : {1}",soBHXH, ngayNamVienBHXH);
        }
        
    }
}
