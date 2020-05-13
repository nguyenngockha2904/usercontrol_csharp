using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public class Infomations
    {
        private string ten;
        private string ngheNghiep;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;

        public string Ten { get => ten; set => ten = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
