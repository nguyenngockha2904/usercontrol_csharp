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
    public partial class ButtonControl : UserControl
    {
        public ButtonControl()
        {
            InitializeComponent();
        }
        public event EventHandler btnThemClicked;
        public event EventHandler btnSuaClicked;
        public event EventHandler btnXoaClicked;
        public Button BtnThem
        {
            get { return btnThem; }
            set { btnThem= value; }
        }
        public Button BtnSua
        {
            get { return btnSua; }
            set { btnSua = value; }
        }
        public Button BtnXoa
        {
            get { return btnXoa; }
            set { btnXoa = value; }
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            btnThemClicked(sender, e);
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            btnSuaClicked(sender, e);
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoaClicked(sender, e);
        }
    }
}
