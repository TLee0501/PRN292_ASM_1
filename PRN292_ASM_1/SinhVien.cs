using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_ASM_1
{
    public class SinhVien
    {
        private string mMaSV;
        private string HoTen;
        private string NgaySinh;
        private string DiaChi;
        private string DienThoai;

        public SinhVien()
        {
            mMaSV = null;
            HoTen = null;
            NgaySinh = null;
            DiaChi = null;
            DienThoai = null;
        }

        public SinhVien(string mMaSV, string HoTen, string NgaySinh, string DiaChi, string DienThoai)
        {
            this.mMaSV = mMaSV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.DienThoai = DienThoai;
        }

        public string MSSV
        {
            get
            {
                return mMaSV;
            }
            set
            {
                mMaSV = value;
            }
        }

        public string HT
        {
            get
            {
                return HoTen;
            }
            set
            {
                HoTen = value;
            }
        }

        public string NS
        {
            get
            {
                return NgaySinh;
            }
            set
            {
                NgaySinh = value;
            }
        }

        public string DC
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }

        public string SDT
        {
            get
            {
                return DienThoai;
            }
            set
            {
                DienThoai = value;
            }
        }

        public void XemThongTin()
        {
            Console.WriteLine("\n**********     Thong tin sinh vien     **********");
            Console.WriteLine("Ma so SV: " + mMaSV);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Ngay sinh: " + NgaySinh);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Dien thoai: " + DienThoai);
        }

        public void xemdanhsachSV(List<SinhVien> danhSachSinhVien)
        {
            if(danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("\nKhong ton tai SV trong danh sach");
            }
            else
            {
                for (int i = 0; i < danhSachSinhVien.Count; i++)
                {
                    Console.WriteLine("STT: " + i + " --------------------------------------");
                    Console.WriteLine("Ma sinh vien: " + danhSachSinhVien[i].MSSV);
                    Console.WriteLine("Ho ten: " + danhSachSinhVien[i].HT);
                    Console.WriteLine("Ngay sinh: " + danhSachSinhVien[i].NS);
                    Console.WriteLine("Dia chi: " + danhSachSinhVien[i].DC);
                    Console.WriteLine("Dien thoai: " + danhSachSinhVien[i].SDT);
                }
                    
            }
        }

        public void themSV(List<SinhVien> danhSachSinhVien)
        {
            string id;
            string ht;
            string ns;
            string dc;
            string dt;
            Console.Write("Ma Sinh Vien: ");
            id = Console.ReadLine();
            if (checkid(danhSachSinhVien, id))
            {
                Console.Write("Ho ten: ");
                ht = Console.ReadLine();
                Console.Write("Ngay sinh: ");
                ns = Console.ReadLine();
                Console.Write("Dia chi: ");
                dc = Console.ReadLine();
                Console.Write("Dien thoai: ");
                dt = Console.ReadLine();
                SinhVien sv = new SinhVien(id, ht, ns, dc, dt);
                danhSachSinhVien.Add(sv);
            }
            else
            {
                Console.WriteLine("Ma so sinh vien da ton tai");
            }
        }

        public void timSV(List<SinhVien> danhSachSinhVien, string id)
        {
            bool result = false;
            for (int i = 0; i < danhSachSinhVien.Count; i++)
            {
                if (danhSachSinhVien[i].MSSV == id)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Ma sinh vien: " + danhSachSinhVien[i].MSSV);
                    Console.WriteLine("Ho ten: " + danhSachSinhVien[i].HT);
                    Console.WriteLine("Ngay sinh: " + danhSachSinhVien[i].NS);
                    Console.WriteLine("Dia chi: " + danhSachSinhVien[i].DC);
                    Console.WriteLine("Dien thoai: " + danhSachSinhVien[i].SDT);
                    result = true;
                }
            }
            if (result == false)
                Console.WriteLine("\nKhong tim thay sinh vien co ma so " + id);
        }

        public void capnhatthongtinSV(List<SinhVien> danhSachSinhVien, string id)
        {
            for (int i = 0; i < danhSachSinhVien.Count; i++)
            {
                if (danhSachSinhVien[i].MSSV == id)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Ma sinh vien: " + danhSachSinhVien[i].MSSV);
                    Console.Write("Ho ten: ");
                    string cnhoten = Console.ReadLine();
                    Console.Write("Ngay sinh: ");
                    string cnngaysinh = Console.ReadLine();
                    Console.Write("Dia chi: ");
                    string cndiachi = Console.ReadLine();
                    Console.Write("Dien thoai: ");
                    string cndienthoai = Console.ReadLine();
                    SinhVien sv = new SinhVien(id, cnhoten, cnngaysinh, cndiachi, cndiachi);
                    danhSachSinhVien.RemoveAt(i);
                    danhSachSinhVien.Add(sv);
                }
            }
        }

        public bool checkid(List<SinhVien> danhSachSinhVien, string id)
        {
            bool result = true;

            for (int i = 0; i < danhSachSinhVien.Count; i++)
                if (danhSachSinhVien[i].MSSV == id)
                {
                    result = false;
                }
            return result;
        }
    }
}
