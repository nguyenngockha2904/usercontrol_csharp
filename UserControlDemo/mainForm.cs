using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserControlDemo
{
    public partial class MainForm : Form
    {
        List<Infomations> mainList = new List<Infomations>();
        int index;
        public MainForm()
        {
       //     dgvInfomations.Rows[0].Selected = true;
            InitializeComponent();
            updateDgv();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvInfomations.AutoGenerateColumns = false;
            if (dgvInfomations.Rows.Count > 0) {
                dgvInfomations.Rows[0].Selected = true;
            }
            
        }

        protected void buttonControlMain_Load(object sender, EventArgs e)
        {
            buttonControlMain.btnThemClicked += new EventHandler(them);
            buttonControlMain.btnSuaClicked += new EventHandler(sua);
            buttonControlMain.btnXoaClicked += new EventHandler(xoa);
        }
        int i=1;
        protected void them(object sender, EventArgs e)
        {
            Infomations newInfo = new Infomations();
            newInfo.Id = i++;
            newInfo.Ten = infomationsMain.Ten;
            newInfo.NgaySinh = infomationsMain.NgaySinh;
            newInfo.GioiTinh = infomationsMain.GioiTinh;
            newInfo.NgheNghiep = infomationsMain.NgheNghiep;
            newInfo.DiaChi = infomationsMain.DiaChi;
            mainList.Add(newInfo);
            updateDgv();
        }

        private void updateDgv()
        {
            dgvInfomations.DataSource = null;
            dgvInfomations.DataSource = mainList;
        }

        protected void sua(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
            String Ten = infomationsMain.Ten;
            DateTime NgaySinh = infomationsMain.NgaySinh;
            String GioiTinh = infomationsMain.GioiTinh;
            String NgheNghiep = infomationsMain.NgheNghiep;
            String DiaChi = infomationsMain.DiaChi;
            mainList[index].Ten=Ten;
            mainList[index].NgaySinh = NgaySinh;
            mainList[index].GioiTinh = GioiTinh;
            mainList[index].NgheNghiep = NgheNghiep;
            mainList[index].DiaChi = DiaChi;

            updateDgv();
        }   

        protected void xoa(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
            int count = dgvInfomations.Rows.Count;
            if (count > 0) {
                mainList.RemoveAt(index);
                updateDgv();
            }
            
        }

        private void dgvInfomations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dgvInfomations.Rows.Count;
            if (count > 0) {
                index = dgvInfomations.CurrentRow.Index;
                DataGridViewRow selectedRow = dgvInfomations.Rows[index];
                infomationsMain.Ten = selectedRow.Cells[1].Value.ToString();
                infomationsMain.NgheNghiep = selectedRow.Cells[2].Value.ToString();
                infomationsMain.NgaySinh = (DateTime)selectedRow.Cells[3].Value;
                infomationsMain.GioiTinh = selectedRow.Cells[4].Value.ToString();
                infomationsMain.DiaChi = selectedRow.Cells[5].Value.ToString();
            }
            
        }
    }
}
