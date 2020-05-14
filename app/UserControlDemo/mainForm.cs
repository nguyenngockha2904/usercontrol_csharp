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
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvInfomations.AutoGenerateColumns = false;
            buttonControlMain.BtnXoa.ForeColor = Color.White;
        }

        protected void buttonControlMain_Load(object sender, EventArgs e)
        {
            buttonControlMain.btnThemClicked += new EventHandler(them);
            buttonControlMain.btnSuaClicked += new EventHandler(sua);
            buttonControlMain.btnXoaClicked += new EventHandler(xoa);
            infomationsMain.textChange += new EventHandler(txt_TextChanged);


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
            xoaTrang();
        }
        public void xoaTrang()
        {
            infomationsMain.Ten="";
            infomationsMain.NgaySinh=DateTime.Now;
            infomationsMain.NgheNghiep="";
            infomationsMain.DiaChi="";
        }
        private void updateDgv()
        {
            dgvInfomations.DataSource = null;
            dgvInfomations.DataSource = mainList;
        }

        protected void sua(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvInfomations.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            Infomations foundpr1 = mainList.Find((Infomations k) => { return (k.Id == id); });
            int index= mainList.IndexOf(foundpr1);
            mainList[index].Ten = infomationsMain.Ten;
            mainList[index].NgaySinh = infomationsMain.NgaySinh;
            mainList[index].GioiTinh = infomationsMain.GioiTinh;
            mainList[index].NgheNghiep = infomationsMain.NgheNghiep;
            mainList[index].DiaChi = infomationsMain.DiaChi;
            updateDgv();
            xoaTrang();
        }   

        protected void xoa(object sender, EventArgs e)
        {
            int count = dgvInfomations.Rows.Count;
            if (count > 0)
            {
                int id= Convert.ToInt32(dgvInfomations.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            Infomations foundpr1 = mainList.Find((Infomations k) => { return (k.Id == id); });           
                mainList.Remove(foundpr1);
                updateDgv();
                xoaTrang();
            }
            
        }       
        private void dgvInfomations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonControlMain.BtnSua.Enabled = true;
            buttonControlMain.BtnXoa.Enabled = true;
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
        public bool kiemtra()
        {
            if (infomationsMain.Ten == "" ||
               infomationsMain.NgheNghiep == "" ||
               infomationsMain.DiaChi == ""
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                buttonControlMain.BtnThem.Enabled = true;
            } else
                buttonControlMain.BtnThem.Enabled = false;
        }
    }
}
