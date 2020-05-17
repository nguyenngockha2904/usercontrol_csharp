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
        public static bool logged = false;
        int index, i = 1;

        public MainForm()
        {
            InitializeComponent();
            dgvInfomations.AutoGenerateColumns = false;

            //button control
            buttonControlMain.AddUser += AddUser;
            buttonControlMain.EditUser += EditUser;
            buttonControlMain.DeleteUser += DeleteUser;

            //infomations control
            infomationsControlMain.TextChangedHanlder += TextChangedHanlder;
        }


        protected void AddUser(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Notification",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Infomations newInfo = new Infomations();
                newInfo.Id = i++;
                newInfo.Ten = infomationsControlMain.Ten;
                newInfo.NgaySinh = infomationsControlMain.NgaySinh;
                newInfo.GioiTinh = infomationsControlMain.GioiTinh;
                newInfo.NgheNghiep = infomationsControlMain.NgheNghiep;
                newInfo.DiaChi = infomationsControlMain.DiaChi;
                mainList.Add(newInfo);
                updateDgv();
                xoaTrang();
            }

        }

        public void xoaTrang()
        {
            infomationsControlMain.Ten="";
            infomationsControlMain.NgaySinh=DateTime.Now;
            infomationsControlMain.NgheNghiep="";
            infomationsControlMain.DiaChi="";
            buttonControlMain.BtnXoa.Enabled = false;
            buttonControlMain.BtnThem.Enabled = false;
            buttonControlMain.BtnSua.Enabled = false;
        }

        private void updateDgv()
        {
            dgvInfomations.DataSource = null;
            dgvInfomations.DataSource = mainList;
        }

        protected void EditUser(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Notification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvInfomations.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                Infomations foundpr1 = mainList.Find((Infomations k) => { return (k.Id == id); });
                int index = mainList.IndexOf(foundpr1);
                mainList[index].Ten = infomationsControlMain.Ten;
                mainList[index].NgaySinh = infomationsControlMain.NgaySinh;
                mainList[index].GioiTinh = infomationsControlMain.GioiTinh;
                mainList[index].NgheNghiep = infomationsControlMain.NgheNghiep;
                mainList[index].DiaChi = infomationsControlMain.DiaChi;
                updateDgv();
                xoaTrang();
            }

        }   

        protected void DeleteUser(object sender, EventArgs e)
        {

            if(logged)
            {
                int count = dgvInfomations.Rows.Count;
                if (count > 0)
                {
                    if (MessageBox.Show("Are you sure?", "Notification",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dgvInfomations.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                        Infomations foundpr1 = mainList.Find((Infomations k) => { return (k.Id == id); });
                        mainList.Remove(foundpr1);
                        updateDgv();
                        xoaTrang();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must login again to delete users", "Login Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoginAgain loginAgain = new LoginAgain();
                loginAgain.ShowDialog();
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
         
                infomationsControlMain.Ten = selectedRow.Cells[1].Value.ToString();
                infomationsControlMain.NgheNghiep = selectedRow.Cells[2].Value.ToString();
                infomationsControlMain.NgaySinh = (DateTime)selectedRow.Cells[3].Value;
                infomationsControlMain.GioiTinh = selectedRow.Cells[4].Value.ToString();
                infomationsControlMain.DiaChi = selectedRow.Cells[5].Value.ToString(); 
            }
            
        }

        public bool kiemtra()
        {
            if (infomationsControlMain.Ten == "" ||
               infomationsControlMain.NgheNghiep == "" ||
               infomationsControlMain.DiaChi == ""
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonControlMain_Load(object sender, EventArgs e)
        {

        }

        private void TextChangedHanlder(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                buttonControlMain.BtnThem.Enabled = true;
            } else
                buttonControlMain.BtnThem.Enabled = false;
        }
    }
}
