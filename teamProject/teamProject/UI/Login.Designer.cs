namespace teamProject.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.password = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_Save = new System.Windows.Forms.CheckBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.password.Location = new System.Drawing.Point(179, 227);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(258, 26);
            this.password.TabIndex = 6;
            this.password.Text = "비밀번호를 입력해주세요";
            this.password.UseSystemPasswordChar = true;
            this.password.Click += new System.EventHandler(this.password_TextChanged);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.id.Location = new System.Drawing.Point(179, 197);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(258, 26);
            this.id.TabIndex = 5;
            this.id.Text = "아이디를 입력해주세요(대소문자 유의)";
            this.id.Click += new System.EventHandler(this.id_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Save
            // 
            this.Login_Save.AutoSize = true;
            this.Login_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_Save.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Login_Save.ForeColor = System.Drawing.Color.SlateGray;
            this.Login_Save.Location = new System.Drawing.Point(250, 264);
            this.Login_Save.Name = "Login_Save";
            this.Login_Save.Size = new System.Drawing.Size(113, 16);
            this.Login_Save.TabIndex = 12;
            this.Login_Save.Text = "로그인정보저장";
            this.Login_Save.UseVisualStyleBackColor = true;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(225, 291);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(161, 49);
            this.Login_button.TabIndex = 13;
            this.Login_button.Text = "로그인하기";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.ForeColor = System.Drawing.Color.SlateGray;
            this.user.Location = new System.Drawing.Point(250, 170);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(47, 16);
            this.user.TabIndex = 14;
            this.user.TabStop = true;
            this.user.Text = "유저";
            this.user.UseVisualStyleBackColor = true;
            this.user.CheckedChanged += new System.EventHandler(this.radioChangeCheck);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.ForeColor = System.Drawing.Color.SlateGray;
            this.admin.Location = new System.Drawing.Point(323, 170);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(59, 16);
            this.admin.TabIndex = 14;
            this.admin.TabStop = true;
            this.admin.Text = "관리인";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.CheckedChanged += new System.EventHandler(this.radioChangeCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(258, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 76);
            this.label1.TabIndex = 15;
            this.label1.Text = "C O S";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Login_Save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Form";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Login_Save;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.Label label1;
    }
}