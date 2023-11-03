using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhan
{
    internal class QuanLyBenhNhan
    {
        Dictionary<string, BenhNhan> danhsach;

        public QuanLyBenhNhan(Dictionary<string, BenhNhan> danhsach) => this.danhsach = danhsach;
        public QuanLyBenhNhan()
        {
            Danhsach = new Dictionary<string, BenhNhan>();

        }

        internal Dictionary<string, BenhNhan> Danhsach { get => danhsach; set => danhsach = value; }
        public BenhNhanBHYT BenhNhan { get; private set; }

        public virtual void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine(" Vui lòng chọn lựa chọn \n  1.Nhận bệnh nhân BHYT \n 2.Nhập Bệnh Nhân BHXH \n 3.Thoát");
                string option = Console.ReadLine().ToUpper();
                if (option == "3") break;
                if (option == "1")
                {
                    BenhNhan bn = new BenhNhanBHYT();
                    while (true)
                    {
                        try
                        {
                            bn.Nhap();
                            Danhsach.Add(bn.MaBenhNhan, bn);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("nhap khong hop le !!!");
                        }
                    }

                }
                if (option == "2")
                {
                    BenhNhan bn = new BenhNhanBHXH();
                    while (true)
                    {
                        try
                        {
                            bn.Nhap();
                            Danhsach.Add(bn.MaBenhNhan, bn);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhap khong hop le !!! ");
                        }
                    }

                }

            }
            
        }
        public void xuat()
        {
            Console.WriteLine("Danh sách bệnh nhân  : ");
            foreach (BenhNhan item in Danhsach.Values) {
            item.Xuat();}
        }
        public void TongTienVienPhi()
        {
            double TongVienPhi;

            
            
        }
    }
    }
