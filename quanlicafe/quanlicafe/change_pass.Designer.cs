namespace quanlicafe
{
    partial class c
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(c));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.current_pass = new System.Windows.Forms.TextBox();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // current_pass
            // 
            this.current_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.current_pass.Font = new System.Drawing.Font("Arial", 12F);
            this.current_pass.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.current_pass.Location = new System.Drawing.Point(422, 86);
            this.current_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.current_pass.Name = "current_pass";
            this.current_pass.PasswordChar = '*';
            this.current_pass.Size = new System.Drawing.Size(178, 19);
            this.current_pass.TabIndex = 2;
            this.current_pass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // new_pass
            // 
            this.new_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_pass.Font = new System.Drawing.Font("Arial", 12F);
            this.new_pass.Location = new System.Drawing.Point(422, 132);
            this.new_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_pass.Name = "new_pass";
            this.new_pass.PasswordChar = '*';
            this.new_pass.Size = new System.Drawing.Size(178, 19);
            this.new_pass.TabIndex = 3;
            this.new_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(305, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.BackColorChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel.Location = new System.Drawing.Point(437, 297);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(87, 36);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // confirm_pass
            // 
            this.confirm_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirm_pass.Font = new System.Drawing.Font("Arial", 12F);
            this.confirm_pass.Location = new System.Drawing.Point(422, 186);
            this.confirm_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm_pass.Name = "confirm_pass";
            this.confirm_pass.PasswordChar = '*';
            this.confirm_pass.Size = new System.Drawing.Size(178, 19);
            this.confirm_pass.TabIndex = 7;
            // 
            // c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(871, 453);
            this.Controls.Add(this.confirm_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.current_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "c";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change password";
            this.Load += new System.EventHandler(this.change_pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox current_pass;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirm_pass;
    }
}