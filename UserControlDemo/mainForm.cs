using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserControlDemo
{
    public partial class MainForm : Form
    {
        List<Infomations> mainList = new List<Infomations>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        protected void buttonControlMain_Load(object sender, EventArgs e)
        {
            buttonControlMain.btnThemClicked += new EventHandler(them);
            buttonControlMain.btnSuaClicked += new EventHandler(sua);
            buttonControlMain.btnXoaClicked += new EventHandler(xoa);
        }

        protected void them(object sender, EventArgs e)
        {
            Infomations newInfo = new Infomations();
            newInfo.Ten = infomationsMain.Ten; ;
            newInfo.NgaySinh = infomationsMain.NgaySinh;
            newInfo.GioiTinh = infomationsMain.GioiTinh;
            newInfo.NgheNghiep = infomationsMain.NgheNghiep;
            newInfo.DiaChi = infomationsMain.DiaChi;
            mainList.Add(newInfo);
            updateDgv();
        }

        private void updateDgv()
        {

            dgvInfomations.Update();
            dgvInfomations.Refresh();
        }

        protected void sua(object sender, EventArgs e)
        {
            dgvInfomations.DataSource = mainList;
        }

        protected void xoa(object sender, EventArgs e)
        {

        }
    }
}
