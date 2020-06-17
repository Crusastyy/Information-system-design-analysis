namespace quanlicafe
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.changepass = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changepass
            // 
            this.changepass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changepass.BackgroundImage")));
            this.changepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.changepass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changepass.Location = new System.Drawing.Point(78, 366);
            this.changepass.Name = "changepass";
            this.changepass.Size = new System.Drawing.Size(204, 64);
            this.changepass.TabIndex = 0;
            this.changepass.Text = "Change password";
            this.changepass.UseVisualStyleBackColor = true;
            this.changepass.Click += new System.EventHandler(this.button1_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout.Location = new System.Drawing.Point(78, 467);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(204, 64);
            this.logout.TabIndex = 1;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // homebutton
            // 
            this.homebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homebutton.BackgroundImage")));
            this.homebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.homebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homebutton.Location = new System.Drawing.Point(774, 158);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(204, 64);
            this.homebutton.TabIndex = 2;
            this.homebutton.Text = "Home";
            this.homebutton.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.Location = new System.Drawing.Point(774, 246);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(204, 64);
            this.menu.TabIndex = 3;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            // 
            // employee
            // 
            this.employee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee.BackgroundImage")));
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.employee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employee.Location = new System.Drawing.Point(774, 334);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(204, 64);
            this.employee.TabIndex = 4;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            this.customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customer.BackgroundImage")));
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer.Location = new System.Drawing.Point(774, 422);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(204, 65);
            this.customer.TabIndex = 5;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("report.BackgroundImage")));
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report.Location = new System.Drawing.Point(774, 510);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(204, 64);
            this.report.TabIndex = 6;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 666);
            this.Controls.Add(this.report);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.changepass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changepass;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button report;
    }
}