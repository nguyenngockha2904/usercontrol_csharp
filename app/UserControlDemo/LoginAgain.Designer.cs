namespace UserControlDemo
{
    partial class LoginAgain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAgain));
            this.loginAgainControl = new UserControlDemo.LoginControl();
            this.SuspendLayout();
            // 
            // loginAgainControl
            // 
            this.loginAgainControl.LabelName = "Username";
            this.loginAgainControl.LabelPassword = "Password";
            this.loginAgainControl.Location = new System.Drawing.Point(12, 12);
            this.loginAgainControl.LoginButtonText = "Log In";
            this.loginAgainControl.Name = "loginAgainControl";
            this.loginAgainControl.Size = new System.Drawing.Size(303, 155);
            this.loginAgainControl.TabIndex = 0;
            // 
            // LoginAgain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 165);
            this.Controls.Add(this.loginAgainControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginAgain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Again";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControl loginAgainControl;
    }
}