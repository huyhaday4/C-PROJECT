using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class NguoiDung
    {
        private string taikhoan, maukhau, hoten, email, phone, diachi;
        public NguoiDung()
        {
            taikhoan = maukhau = hoten = email = phone = diachi = "";
        }
        public NguoiDung(string ten, string tk, string mk, string em, string sdt, string dc)
        {
            taikhoan = tk;
            maukhau = mk;
            hoten = ten;
            email = em;
            phone = sdt;
            diachi = dc;
        }
        public bool Kiemtramk()//kt mk tối thiểu 7 ký tự và có cả chữ và số.
        {

            if (maukhau.Length < 7)
            {
                return false;
            }

            bool kiemtrachu = false;//chưa có chữ
            bool kiemtraso = false;//chưa có số
            for (int i = 0; i < maukhau.Length; ++i)
            {
                if (kiemtrachu == true && kiemtraso == true)
                {
                    break;//dừng vòng lặp 
                }
                //A-Z:Bắt đầu 65
                //a-z:Bắt đầu là 97
                if (maukhau[i] >= 'A' && maukhau[i] <= 'Z' || (maukhau[i] >= 'a' && maukhau[i] <= 'z'))
                {
                    kiemtrachu = true;
                }
                if (maukhau[i] >= '0' && maukhau[i] <= '9')
                {
                    kiemtraso = true;
                }

                if (kiemtraso == false || kiemtrachu == false)
                {
                    return false;//ko hợp lệ
                }
            }
            return true;//hợp lệ
        }
    }
}
