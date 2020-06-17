namespace Project
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbDrinkCount = new System.Windows.Forms.Label();
            this.nmDrinkCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.lbDrink = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkCount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 285);
            this.panel1.TabIndex = 0;
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(776, 285);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.adminToolStripMenuItem.Text = "Admin ";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbDrinkCount);
            this.panel4.Controls.Add(this.nmDrinkCount);
            this.panel4.Controls.Add(this.btnAddDrink);
            this.panel4.Controls.Add(this.lbDrink);
            this.panel4.Controls.Add(this.lbCategory);
            this.panel4.Controls.Add(this.cbDrink);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(12, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 59);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbDrinkCount
            // 
            this.lbDrinkCount.AutoSize = true;
            this.lbDrinkCount.Location = new System.Drawing.Point(641, 10);
            this.lbDrinkCount.Name = "lbDrinkCount";
            this.lbDrinkCount.Size = new System.Drawing.Size(52, 13);
            this.lbDrinkCount.TabIndex = 6;
            this.lbDrinkCount.Text = "Số lượng:";
            // 
            // nmDrinkCount
            // 
            this.nmDrinkCount.Location = new System.Drawing.Point(644, 26);
            this.nmDrinkCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDrinkCount.Name = "nmDrinkCount";
            this.nmDrinkCount.Size = new System.Drawing.Size(120, 20);
            this.nmDrinkCount.TabIndex = 5;
            this.nmDrinkCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(523, 3);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(99, 48);
            this.btnAddDrink.TabIndex = 4;
            this.btnAddDrink.Text = "Thêm ";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDrink
            // 
            this.lbDrink.AutoSize = true;
            this.lbDrink.Location = new System.Drawing.Point(7, 33);
            this.lbDrink.Name = "lbDrink";
            this.lbDrink.Size = new System.Drawing.Size(56, 13);
            this.lbDrink.TabIndex = 3;
            this.lbDrink.Text = "Tên nước:";
            this.lbDrink.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(9, 6);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(57, 13);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Loại nước:";
            this.lbCategory.Click += new System.EventHandler(this.lbCategory_Click);
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(128, 30);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(372, 21);
            this.cbDrink.TabIndex = 1;
            this.cbDrink.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(128, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(372, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmDiscount);
            this.panel2.Controls.Add(this.btnDiscount);
            this.panel2.Controls.Add(this.btnCheckout);
            this.panel2.Location = new System.Drawing.Point(12, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 55);
            this.panel2.TabIndex = 5;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(0, 31);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(183, 20);
            this.nmDiscount.TabIndex = 7;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(3, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(180, 23);
            this.btnDiscount.TabIndex = 6;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(189, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(584, 48);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTableManager";
            this.Text = "Phần mềm quản lý quán cafe";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkCount)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbDrink;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Label lbDrinkCount;
        private System.Windows.Forms.NumericUpDown nmDrinkCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.NumericUpDown nmDiscount;
    }
}

