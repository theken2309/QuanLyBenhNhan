using System.Text;

namespace QuanLyBenhNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("************CHÀO MỪNG ĐẾN VỚI QUẢN LÝ BỆNH VIỆN******************");
            
            QuanLyBenhNhan ds = new QuanLyBenhNhan();
            ds.nhap();
            ds.xuat();
            Console.ReadLine();
        }
    }
}