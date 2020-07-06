namespace quanlicafe
{
    partial class thanhtoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tongtien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tienthoi = new System.Windows.Forms.Label();
            this.Tienkhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.khachhang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tongtien
            // 
            this.Tongtien.AutoSize = true;
            this.Tongtien.Location = new System.Drawing.Point(221, 76);
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.Size = new System.Drawing.Size(25, 13);
            this.Tongtien.TabIndex = 1;
            this.Tongtien.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiền thối";
            // 
            // Tienthoi
            // 
            this.Tienthoi.AutoSize = true;
            this.Tienthoi.Location = new System.Drawing.Point(221, 165);
            this.Tienthoi.Name = "Tienthoi";
            this.Tienthoi.Size = new System.Drawing.Size(25, 13);
            this.Tienthoi.TabIndex = 4;
            this.Tienthoi.Text = "123";
            // 
            // Tienkhach
            // 
            this.Tienkhach.Location = new System.Drawing.Point(224, 120);
            this.Tienkhach.Name = "Tienkhach";
            this.Tienkhach.Size = new System.Drawing.Size(120, 20);
            this.Tienkhach.TabIndex = 5;
            this.Tienkhach.Text = "0";
            this.Tienkhach.TextChanged += new System.EventHandler(this.Tienkhach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khach Hang";
            // 
            // khachhang
            // 
            this.khachhang.Location = new System.Drawing.Point(224, 203);
            this.khachhang.Name = "khachhang";
            this.khachhang.Size = new System.Drawing.Size(120, 20);
            this.khachhang.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(443, 392);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.khachhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tienkhach);
            this.Controls.Add(this.Tienthoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tongtien);
            this.Controls.Add(this.label1);
            this.Name = "thanhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "n";
            this.Load += new System.EventHandler(this.thanhtoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Tienthoi;
        private System.Windows.Forms.TextBox Tienkhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox khachhang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}