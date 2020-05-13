using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class InfomationsControl : UserControl
    {
        public InfomationsControl()
        {
            InitializeComponent();
        }

        private void Infomations_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedIndex = 0;
        }
        public String Ten
        {
            get { return txtTen.Text; }
            set { txtTen.Text = value; }
        }
        public String NgheNghiep
        {
            get { return txtNgheNghiep.Text; }
            set { txtNgheNghiep.Text = value; }
        }
        public DateTime NgaySinh
        {
            get { return dtpNgaySinh.Value.Date; }
            set { dtpNgaySinh.Value = value; }
        }
        public String GioiTinh
        {
            get { return cbGioiTinh.Text; }
            set { cbGioiTinh.Text = value; }
        }
        public String DiaChi
        {
            get { return txtDiaChi.Text; }
            set { txtDiaChi.Text = value; }
        }
    }
}
