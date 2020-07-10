namespace quanlicafe
{
    partial class frmemp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucdanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_but = new System.Windows.Forms.Button();
            this.edit_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoten,
            this.ngaysinh,
            this.sdt,
            this.gioitinh,
            this.email,
            this.chucdanh});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Ho ten ";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngay sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "so dien thoai";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "gioi tinh";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // chucdanh
            // 
            this.chucdanh.HeaderText = "chuc danh";
            this.chucdanh.Name = "chucdanh";
            this.chucdanh.ReadOnly = true;
            // 
            // add_but
            // 
            this.add_but.Location = new System.Drawing.Point(12, 31);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(75, 23);
            this.add_but.TabIndex = 1;
            this.add_but.Text = "Add";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // edit_but
            // 
            this.edit_but.Location = new System.Drawing.Point(136, 30);
            this.edit_but.Name = "edit_but";
            this.edit_but.Size = new System.Drawing.Size(75, 23);
            this.edit_but.TabIndex = 2;
            this.edit_but.Text = "Edit";
            this.edit_but.UseVisualStyleBackColor = true;
            this.edit_but.Click += new System.EventHandler(this.edit_but_Click);
            // 
            // frmemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(799, 423);
            this.Controls.Add(this.edit_but);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmemp";
            this.Text = "frmemp";
            this.Load += new System.EventHandler(this.frmemp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucdanh;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.Button edit_but;
    }
}