namespace OnlineBookShop
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button8 = new Button();
            checkBox1 = new CheckBox();
            textBox9 = new TextBox();
            textBox13 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(-2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 86);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 0, 64);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(130, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 50);
            textBox2.TabIndex = 11;
            textBox2.Text = "LOGIN";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(43, 116);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 27);
            textBox4.TabIndex = 14;
            textBox4.Text = "Username or email address*";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(43, 206);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(255, 27);
            textBox7.TabIndex = 17;
            textBox7.Text = "Password*";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Control;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 7.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(86, 388);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(255, 18);
            textBox8.TabIndex = 18;
            textBox8.Text = "Forget your password?";
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // button8
            // 
            button8.BackColor = Color.Teal;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(86, 330);
            button8.Name = "button8";
            button8.Size = new Size(168, 52);
            button8.TabIndex = 19;
            button8.Text = "LOGIN";
            button8.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(43, 282);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(44, 149);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(274, 27);
            textBox9.TabIndex = 22;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(43, 236);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(274, 27);
            textBox13.TabIndex = 26;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(237, 451);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 27;
            textBox1.Text = "Sign Up";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 451);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 28;
            textBox3.Text = "Don't have an Account?";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(380, 503);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox13);
            Controls.Add(textBox9);
            Controls.Add(checkBox1);
            Controls.Add(button8);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "log_register";
            Load += log_register_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button8;
        private CheckBox checkBox1;
        private TextBox textBox9;
        private TextBox textBox13;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}