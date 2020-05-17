namespace UserControlDemo
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvInfomations = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonControlMain = new UserControlDemo.ButtonControl();
            this.infomationsMain = new UserControlDemo.InfomationsControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfomations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfomations
            // 
            this.dgvInfomations.AllowUserToAddRows = false;
            this.dgvInfomations.AllowUserToDeleteRows = false;
            this.dgvInfomations.AllowUserToResizeColumns = false;
            this.dgvInfomations.AllowUserToResizeRows = false;
            this.dgvInfomations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvInfomations.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfomations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfomations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfomations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.ngheNghiep,
            this.ngaySinh,
            this.gioiTinh,
            this.diaChi});
            this.dgvInfomations.Location = new System.Drawing.Point(22, 240);
            this.dgvInfomations.MultiSelect = false;
            this.dgvInfomations.Name = "dgvInfomations";
            this.dgvInfomations.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfomations.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInfomations.RowHeadersVisible = false;
            this.dgvInfomations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfomations.Size = new System.Drawing.Size(813, 308);
            this.dgvInfomations.TabIndex = 2;
            this.dgvInfomations.TabStop = false;
            this.dgvInfomations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfomations_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ten";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ten.DefaultCellStyle = dataGridViewCellStyle3;
            this.ten.FillWeight = 107.8173F;
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 213;
            // 
            // ngheNghiep
            // 
            this.ngheNghiep.DataPropertyName = "NgheNghiep";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ngheNghiep.DefaultCellStyle = dataGridViewCellStyle4;
            this.ngheNghiep.FillWeight = 107.8173F;
            this.ngheNghiep.HeaderText = "Nghề Nghiệp";
            this.ngheNghiep.Name = "ngheNghiep";
            this.ngheNghiep.ReadOnly = true;
            this.ngheNghiep.Width = 137;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ngaySinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.ngaySinh.FillWeight = 107.8173F;
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            this.ngaySinh.Width = 137;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gioiTinh.DefaultCellStyle = dataGridViewCellStyle6;
            this.gioiTinh.FillWeight = 107.8173F;
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            this.gioiTinh.Width = 136;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.diaChi.DefaultCellStyle = dataGridViewCellStyle7;
            this.diaChi.FillWeight = 107.8173F;
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 137;
            // 
            // buttonControlMain
            // 
            this.buttonControlMain.ForeColor = System.Drawing.Color.White;
            this.buttonControlMain.Location = new System.Drawing.Point(725, 47);
            this.buttonControlMain.Name = "buttonControlMain";
            this.buttonControlMain.Size = new System.Drawing.Size(110, 144);
            this.buttonControlMain.TabIndex = 1;
            this.buttonControlMain.Load += new System.EventHandler(this.buttonControlMain_Load);
            // 
            // infomationsMain
            // 
            this.infomationsMain.DiaChi = "";
            this.infomationsMain.GioiTinh = "Nam";
            this.infomationsMain.Location = new System.Drawing.Point(22, 24);
            this.infomationsMain.Name = "infomationsMain";
            this.infomationsMain.NgaySinh = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            this.infomationsMain.NgheNghiep = "";
            this.infomationsMain.Size = new System.Drawing.Size(697, 184);
            this.infomationsMain.TabIndex = 0;
            this.infomationsMain.Ten = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 560);
            this.Controls.Add(this.dgvInfomations);
            this.Controls.Add(this.buttonControlMain);
            this.Controls.Add(this.infomationsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfomations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InfomationsControl infomationsMain;
        private ButtonControl buttonControlMain;
        private System.Windows.Forms.DataGridView dgvInfomations;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
    }
}

