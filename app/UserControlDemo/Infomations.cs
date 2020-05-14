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
    
        private int id;
        private string ten;
        private string ngheNghiep;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        public Infomations() {
        
        }
        public Infomations(int id,string ten , String ngheNghiep ,DateTime ngaySinh , String gioiTinh,String diaChi)
        {
            this.id = id;
            this.ten = ten;
            this.ngheNghiep = ngheNghiep;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }
        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
