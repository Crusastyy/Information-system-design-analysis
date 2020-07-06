namespace quanlicafe
{
    partial class fprofile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fprofile));
            this.emp_name = new System.Windows.Forms.Label();
            this.emp_dob = new System.Windows.Forms.Label();
            this.emp_phone = new System.Windows.Forms.Label();
            this.emp_gender = new System.Windows.Forms.Label();
            this.emp_email = new System.Windows.Forms.Label();
            this.emp_position = new System.Windows.Forms.Label();
            this.emp_titile = new System.Windows.Forms.Label();
            this.emp_changepass = new System.Windows.Forms.Button();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.ChucDanh = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.TextBox();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emp_name
            // 
            this.emp_name.AutoSize = true;
            this.emp_name.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.emp_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_name.Location = new System.Drawing.Point(119, 139);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(53, 20);
            this.emp_name.TabIndex = 1;
            this.emp_name.Text = "Name";
            // 
            // emp_dob
            // 
            this.emp_dob.AutoSize = true;
            this.emp_dob.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.emp_dob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_dob.Location = new System.Drawing.Point(504, 139);
            this.emp_dob.Name = "emp_dob";
            this.emp_dob.Size = new System.Drawing.Size(50, 20);
            this.emp_dob.TabIndex = 2;
            this.emp_dob.Text = "D.o.B";
            // 
            // emp_phone
            // 
            this.emp_phone.AutoSize = true;
            this.emp_phone.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.emp_phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_phone.Location = new System.Drawing.Point(119, 186);
            this.emp_phone.Name = "emp_phone";
            this.emp_phone.Size = new System.Drawing.Size(117, 20);
            this.emp_phone.TabIndex = 3;
            this.emp_phone.Text = "Phone number";
            // 
            // emp_gender
            // 
            this.emp_gender.AutoSize = true;
            this.emp_gender.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.emp_gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_gender.Location = new System.Drawing.Point(504, 186);
            this.emp_gender.Name = "emp_gender";
            this.emp_gender.Size = new System.Drawing.Size(64, 20);
            this.emp_gender.TabIndex = 4;
            this.emp_gender.Text = "Gender";
            // 
            // emp_email
            // 
            this.emp_email.AutoSize = true;
            this.emp_email.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.emp_email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_email.Location = new System.Drawing.Point(119, 233);
            this.emp_email.Name = "emp_email";
            this.emp_email.Size = new System.Drawing.Size(56, 20);
            this.emp_email.TabIndex = 5;
            this.emp_email.Text = "Email";
            // 
            // emp_position
            // 
            this.emp_position.AutoSize = true;
            this.emp_position.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.emp_position.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_position.Location = new System.Drawing.Point(119, 280);
            this.emp_position.Name = "emp_position";
            this.emp_position.Size = new System.Drawing.Size(73, 20);
            this.emp_position.TabIndex = 6;
            this.emp_position.Text = "Position";
            // 
            // emp_titile
            // 
            this.emp_titile.AutoSize = true;
            this.emp_titile.Font = new System.Drawing.Font("Lucida Calligraphy", 22F, System.Drawing.FontStyle.Bold);
            this.emp_titile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_titile.Location = new System.Drawing.Point(384, 27);
            this.emp_titile.Name = "emp_titile";
            this.emp_titile.Size = new System.Drawing.Size(130, 39);
            this.emp_titile.TabIndex = 7;
            this.emp_titile.Text = "Profile";
            // 
            // emp_changepass
            // 
            this.emp_changepass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_changepass.Location = new System.Drawing.Point(508, 84);
            this.emp_changepass.Name = "emp_changepass";
            this.emp_changepass.Size = new System.Drawing.Size(153, 31);
            this.emp_changepass.TabIndex = 8;
            this.emp_changepass.Text = "Change password";
            this.emp_changepass.UseVisualStyleBackColor = false;
            this.emp_changepass.Click += new System.EventHandler(this.emp_changepass_Click);
            // 
            // HoTen
            // 
            this.HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HoTen.Location = new System.Drawing.Point(278, 134);
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Size = new System.Drawing.Size(145, 26);
            this.HoTen.TabIndex = 10;
            // 
            // SDT
            // 
            this.SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SDT.Location = new System.Drawing.Point(278, 181);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(145, 26);
            this.SDT.TabIndex = 11;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Email.Location = new System.Drawing.Point(278, 228);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(145, 26);
            this.Email.TabIndex = 12;
            // 
            // ChucDanh
            // 
            this.ChucDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChucDanh.Location = new System.Drawing.Point(278, 275);
            this.ChucDanh.Name = "ChucDanh";
            this.ChucDanh.ReadOnly = true;
            this.ChucDanh.Size = new System.Drawing.Size(145, 26);
            this.ChucDanh.TabIndex = 13;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NgaySinh.Location = new System.Drawing.Point(618, 134);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Size = new System.Drawing.Size(145, 26);
            this.NgaySinh.TabIndex = 14;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(618, 187);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(48, 17);
            this.radio_male.TabIndex = 15;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(704, 187);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(59, 17);
            this.radio_female.TabIndex = 16;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.White;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.button_ok.Location = new System.Drawing.Point(326, 360);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(87, 36);
            this.button_ok.TabIndex = 17;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.White;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.button_cancel.Location = new System.Drawing.Point(458, 360);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 36);
            this.button_cancel.TabIndex = 18;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // fprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(871, 453);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.radio_female);
            this.Controls.Add(this.radio_male);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.ChucDanh);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.emp_changepass);
            this.Controls.Add(this.emp_titile);
            this.Controls.Add(this.emp_position);
            this.Controls.Add(this.emp_email);
            this.Controls.Add(this.emp_gender);
            this.Controls.Add(this.emp_phone);
            this.Controls.Add(this.emp_dob);
            this.Controls.Add(this.emp_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fprofile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.fprofile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label emp_name;
        private System.Windows.Forms.Label emp_dob;
        private System.Windows.Forms.Label emp_phone;
        private System.Windows.Forms.Label emp_gender;
        private System.Windows.Forms.Label emp_email;
        private System.Windows.Forms.Label emp_position;
        private System.Windows.Forms.Label emp_titile;
        private System.Windows.Forms.Button emp_changepass;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox ChucDanh;
        private System.Windows.Forms.TextBox NgaySinh;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}