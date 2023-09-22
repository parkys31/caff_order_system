namespace teamProject.UI
{
    partial class Join
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_please = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.help = new Sunny.UI.UISymbolLabel();
            this.login = new System.Windows.Forms.Button();
            this.all_menu = new Sunny.UI.UISymbolButton();
            this.find = new Sunny.UI.UISymbolButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_please
            // 
            this.Login_please.AutoSize = true;
            this.Login_please.BackColor = System.Drawing.Color.Transparent;
            this.Login_please.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Login_please.ForeColor = System.Drawing.Color.White;
            this.Login_please.Location = new System.Drawing.Point(69, 27);
            this.Login_please.Name = "Login_please";
            this.Login_please.Size = new System.Drawing.Size(186, 31);
            this.Login_please.TabIndex = 0;
            this.Login_please.Text = "로그인 해 주세요.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.Login_please);
            this.panel1.Location = new System.Drawing.Point(-1, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 137);
            this.panel1.TabIndex = 4;
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.help.ForeColor = System.Drawing.Color.White;
            this.help.Location = new System.Drawing.Point(180, 88);
            this.help.MinimumSize = new System.Drawing.Size(1, 1);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(120, 35);
            this.help.Style = Sunny.UI.UIStyle.Custom;
            this.help.Symbol = 116;
            this.help.SymbolColor = System.Drawing.Color.White;
            this.help.TabIndex = 2;
            this.help.Text = "헬프센터";
            this.help.Click += new System.EventHandler(this.uiSymbolLabel1_Click);
            // 
            // login
            // 
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(433, 27);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(95, 31);
            this.login.TabIndex = 1;
            this.login.Text = "로그인";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // all_menu
            // 
            this.all_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.all_menu.FillColor = System.Drawing.Color.Transparent;
            this.all_menu.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.all_menu.Location = new System.Drawing.Point(7, 4);
            this.all_menu.MinimumSize = new System.Drawing.Size(1, 1);
            this.all_menu.Name = "all_menu";
            this.all_menu.Size = new System.Drawing.Size(43, 35);
            this.all_menu.Style = Sunny.UI.UIStyle.Custom;
            this.all_menu.Symbol = 61641;
            this.all_menu.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.all_menu.TabIndex = 5;
            // 
            // find
            // 
            this.find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find.FillColor = System.Drawing.Color.Transparent;
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(504, 5);
            this.find.MinimumSize = new System.Drawing.Size(1, 1);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(44, 35);
            this.find.Style = Sunny.UI.UIStyle.Custom;
            this.find.Symbol = 61442;
            this.find.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.find.TabIndex = 6;
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.find);
            this.Controls.Add(this.all_menu);
            this.Controls.Add(this.panel1);
            this.Name = "Join";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Login_please;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button login;
        private Sunny.UI.UISymbolLabel help;
        private Sunny.UI.UISymbolButton all_menu;
        private Sunny.UI.UISymbolButton find;
    }
}

