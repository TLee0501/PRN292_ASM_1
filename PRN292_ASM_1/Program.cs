using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_ASM_1
{
    class Program
    {
        public static void display_menu()
        {
            Console.WriteLine("\n**********     Menu     **********");
            Console.WriteLine("1 - Xem danh sach sinh vien");
            Console.WriteLine("2 - Them sinh vien");
            Console.WriteLine("3 - Tim sinh vien");
            Console.WriteLine("4 - Cap nhat thong tin sinh vien");
            Console.WriteLine("Other - Quit");
        }

        public static int ChooseOption()
        {
            int choose;
            display_menu();
            Console.Write("Chon chuc nang: ");
            choose = Int32.Parse(Console.ReadLine());
            return choose;
        }

        static void Main(string[] args)
        {
            int choose;
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            SinhVien sv = new SinhVien();
            do
            {
                choose = ChooseOption();
                switch (choose)
                {
                    case 1:
                        sv.xemdanhsachSV(danhSachSinhVien);
                        break;
                    case 2:
                        SinhVien svnew = new SinhVien();
                        sv.themSV(danhSachSinhVien);
                        break;
                    case 3:
                        string id1;
                        Console.Write("Tim sinh vien co ma so: ");
                        id1 = Console.ReadLine();
                        sv.timSV(danhSachSinhVien, id1);
                        break;
                    case 4:
                        string id2;
                        Console.Write("Cap nhat thong tin sinh vien co ma so: ");
                        id2 = Console.ReadLine();
                        sv.capnhatthongtinSV(danhSachSinhVien, id2);
                        break;
                }

            } while (choose > 0 && choose < 5);


        }
    }
}
