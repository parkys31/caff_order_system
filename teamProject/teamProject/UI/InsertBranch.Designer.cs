namespace teamProject.UI
{
    partial class InsertBranch
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.B_branchinsertcancel = new Sunny.UI.UIButton();
            this.B_branchInsertOK = new Sunny.UI.UIButton();
            this.T_addr = new Sunny.UI.UITextBox();
            this.T_tel = new Sunny.UI.UITextBox();
            this.T_name = new Sunny.UI.UITextBox();
            this.T_branchname = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("티웨이_항공", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(258, 25);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 57460;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.SymbolSize = 35;
            this.uiSymbolLabel1.TabIndex = 30;
            this.uiSymbolLabel1.Text = "지점 등록";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel5.Location = new System.Drawing.Point(161, 257);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(90, 35);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 26;
            this.uiLabel5.Text = "매장주소";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel6.Location = new System.Drawing.Point(162, 212);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(89, 35);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 27;
            this.uiLabel6.Text = "전화번호";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel7.Location = new System.Drawing.Point(179, 167);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(72, 35);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 28;
            this.uiLabel7.Text = "점주명";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel8.Location = new System.Drawing.Point(179, 122);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(72, 35);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 29;
            this.uiLabel8.Text = "지점명";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // B_branchinsertcancel
            // 
            this.B_branchinsertcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_branchinsertcancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchinsertcancel.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchinsertcancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchinsertcancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchinsertcancel.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_branchinsertcancel.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchinsertcancel.Location = new System.Drawing.Point(360, 336);
            this.B_branchinsertcancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_branchinsertcancel.Name = "B_branchinsertcancel";
            this.B_branchinsertcancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchinsertcancel.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchinsertcancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchinsertcancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchinsertcancel.Size = new System.Drawing.Size(66, 35);
            this.B_branchinsertcancel.Style = Sunny.UI.UIStyle.Custom;
            this.B_branchinsertcancel.TabIndex = 24;
            this.B_branchinsertcancel.Text = "취소";
            this.B_branchinsertcancel.Click += new System.EventHandler(this.B_branchinsertcancel_Click);
            // 
            // B_branchInsertOK
            // 
            this.B_branchInsertOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_branchInsertOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsertOK.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchInsertOK.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsertOK.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsertOK.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_branchInsertOK.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsertOK.Location = new System.Drawing.Point(279, 336);
            this.B_branchInsertOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_branchInsertOK.Name = "B_branchInsertOK";
            this.B_branchInsertOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsertOK.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchInsertOK.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsertOK.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsertOK.Size = new System.Drawing.Size(66, 35);
            this.B_branchInsertOK.Style = Sunny.UI.UIStyle.Custom;
            this.B_branchInsertOK.TabIndex = 25;
            this.B_branchInsertOK.Text = "등록";
            this.B_branchInsertOK.Click += new System.EventHandler(this.B_branchInsertOK_Click);
            // 
            // T_addr
            // 
            this.T_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_addr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.T_addr.Location = new System.Drawing.Point(258, 256);
            this.T_addr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_addr.MinimumSize = new System.Drawing.Size(1, 16);
            this.T_addr.Name = "T_addr";
            this.T_addr.Padding = new System.Windows.Forms.Padding(5);
            this.T_addr.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_addr.ShowText = false;
            this.T_addr.Size = new System.Drawing.Size(186, 35);
            this.T_addr.Style = Sunny.UI.UIStyle.Custom;
            this.T_addr.TabIndex = 20;
            this.T_addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.T_addr.Watermark = "";
            // 
            // T_tel
            // 
            this.T_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_tel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.T_tel.Location = new System.Drawing.Point(258, 211);
            this.T_tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_tel.MinimumSize = new System.Drawing.Size(1, 16);
            this.T_tel.Name = "T_tel";
            this.T_tel.Padding = new System.Windows.Forms.Padding(5);
            this.T_tel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_tel.ShowText = false;
            this.T_tel.Size = new System.Drawing.Size(186, 35);
            this.T_tel.Style = Sunny.UI.UIStyle.Custom;
            this.T_tel.TabIndex = 21;
            this.T_tel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.T_tel.Watermark = "";
            // 
            // T_name
            // 
            this.T_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.T_name.Location = new System.Drawing.Point(258, 166);
            this.T_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.T_name.Name = "T_name";
            this.T_name.Padding = new System.Windows.Forms.Padding(5);
            this.T_name.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_name.ShowText = false;
            this.T_name.Size = new System.Drawing.Size(186, 35);
            this.T_name.Style = Sunny.UI.UIStyle.Custom;
            this.T_name.TabIndex = 22;
            this.T_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.T_name.Watermark = "";
            // 
            // T_branchname
            // 
            this.T_branchname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_branchname.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.T_branchname.Location = new System.Drawing.Point(258, 121);
            this.T_branchname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_branchname.MinimumSize = new System.Drawing.Size(1, 16);
            this.T_branchname.Name = "T_branchname";
            this.T_branchname.Padding = new System.Windows.Forms.Padding(5);
            this.T_branchname.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_branchname.ShowText = false;
            this.T_branchname.Size = new System.Drawing.Size(186, 35);
            this.T_branchname.Style = Sunny.UI.UIStyle.Custom;
            this.T_branchname.TabIndex = 23;
            this.T_branchname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.T_branchname.Watermark = "";
            // 
            // InsertBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.B_branchinsertcancel);
            this.Controls.Add(this.B_branchInsertOK);
            this.Controls.Add(this.T_addr);
            this.Controls.Add(this.T_tel);
            this.Controls.Add(this.T_name);
            this.Controls.Add(this.T_branchname);
            this.Name = "InsertBranch";
            this.Size = new System.Drawing.Size(678, 508);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIButton B_branchinsertcancel;
        private Sunny.UI.UIButton B_branchInsertOK;
        private Sunny.UI.UITextBox T_addr;
        private Sunny.UI.UITextBox T_tel;
        private Sunny.UI.UITextBox T_name;
        private Sunny.UI.UITextBox T_branchname;
    }
}
