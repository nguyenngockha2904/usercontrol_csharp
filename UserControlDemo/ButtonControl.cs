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
