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

        public delegate void ButtonClickedHandler(object sender, EventArgs e);

        public event ButtonClickedHandler AddUser;
        public event ButtonClickedHandler EditUser;
        public event ButtonClickedHandler DeleteUser;

        public Button BtnThem
        {
            get { return btnThem; }
            set { btnThem = value; }
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
            if (this.AddUser != null)
            {
                AddUser(sender, e);
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (this.EditUser != null)
            {
                EditUser(sender, e);
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.DeleteUser != null)
            {
                DeleteUser(sender, e);
            }
        }
    }
}
