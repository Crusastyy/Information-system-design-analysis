namespace quanlicafe
{
    partial class report
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ngayhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayhd,
            this.thoigianhd,
            this.trigia,
            this.manv});
            this.dataGridView1.Location = new System.Drawing.Point(0, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ngayhd
            // 
            this.ngayhd.HeaderText = "ngay hoa don";
            this.ngayhd.Name = "ngayhd";
            this.ngayhd.ReadOnly = true;
            // 
            // thoigianhd
            // 
            this.thoigianhd.HeaderText = "thoi gian hd";
            this.thoigianhd.Name = "thoigianhd";
            this.thoigianhd.ReadOnly = true;
            // 
            // trigia
            // 
            this.trigia.HeaderText = "tri gia";
            this.trigia.Name = "trigia";
            this.trigia.ReadOnly = true;
            // 
            // manv
            // 
            this.manv.HeaderText = "ma nhan vien";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 343);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "report";
            this.Text = "report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigia;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
    }
}