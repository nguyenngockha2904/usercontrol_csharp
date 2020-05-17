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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        public delegate void EventHandler(Object sender, EventArgs e);
        public event EventHandler LoginSuccess;
        public event EventHandler LoginFailed;

        // This is the very simple Login Check Validation
        // The Password must be ... "secret" .....
        private bool LoginCheck(string pName, string pPassword)
        {
            return pPassword.Equals("secret");
        }

        // Validate Login, in any case call the LoginSuccess or
        // LoginFailed event, which will notify the Application's
        // Event Handlers.
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // User Name Validation
            if (txtUserName.Text.Length == 0)
            {
                erpLoginError.SetError(txtUserName, "Please enter a user name");
                return;
            }
            else
            {
                erpLoginError.SetError(txtUserName, "");
            }

            // Password Validation
            if (txtPassword.Text.Length == 0)
            {
                erpLoginError.SetError(txtPassword, "Please enter a password");
                return;
            }
            else
            {
                erpLoginError.SetError(txtPassword, "");
            }

            // Check Password
            if (LoginCheck(txtUserName.Text, txtPassword.Text))
            {
                // If there any Subscribers for the LoginSuccess
                // Event, notify them ...
                if (LoginSuccess != null)
                {
                    LoginSuccess(this, new System.EventArgs());
                }
            }
            else
            {
                // If there any Subscribers for the LoginFailed
                // Event, notify them ...
                if (LoginFailed != null)
                {
                    LoginFailed(this, new System.EventArgs());
                }
            }
        }

        // Read-Write Property for User Name Label
        public string LabelName
        {
            get
            {
                return lblUserName.Text;
            }
            set
            {
                lblUserName.Text = value;
            }
        }

        // Read-Write Property for User Name Password
        public string LabelPassword
        {
            get
            {
                return lblPassword.Text;
            }
            set
            {
                lblPassword.Text = value;
            }
        }

        // Read-Write Property for Login Button Text
        public string LoginButtonText
        {
            get
            {
                return btnLogin.Text;
            }
            set
            {
                btnLogin.Text = value;
            }
        }

        // Read-Only Property for User Name
        [Browsable(false)]
        public string UserName
        {
            set
            {
                txtUserName.Text = value;
            }
        }

        // Read-Only Property for Password
        [Browsable(false)]
        public string Password
        {
            set
            {
                txtPassword.Text = value;
            }
        }
    }
}
