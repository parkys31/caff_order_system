namespace teamProject.UI
{
    partial class OrderUpdate
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
            this.B_cancelUP = new Sunny.UI.UISymbolButton();
            this.B_orderUP = new Sunny.UI.UISymbolButton();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.L_branchcodeUp = new Sunny.UI.UILabel();
            this.L_branchnameUp = new Sunny.UI.UILabel();
            this.L_nameUp = new Sunny.UI.UILabel();
            this.L_materialnameUp = new Sunny.UI.UILabel();
            this.L_materialcountUp = new Sunny.UI.UILabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.C_statusUp = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.T_wayUp = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.L_ordercodeUp = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // B_cancelUP
            // 
            this.B_cancelUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_cancelUP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_cancelUP.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_cancelUP.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_cancelUP.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_cancelUP.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_cancelUP.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_cancelUP.Location = new System.Drawing.Point(366, 372);
            this.B_cancelUP.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_cancelUP.Name = "B_cancelUP";
            this.B_cancelUP.RectColor = System.Drawing.Color.White;
            this.B_cancelUP.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_cancelUP.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_cancelUP.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_cancelUP.Size = new System.Drawing.Size(87, 35);
            this.B_cancelUP.Style = Sunny.UI.UIStyle.Custom;
            this.B_cancelUP.Symbol = 61453;
            this.B_cancelUP.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_cancelUP.TabIndex = 34;
            this.B_cancelUP.Text = "취소";
            this.B_cancelUP.Click += new System.EventHandler(this.B_cancelUP_Click);
            // 
            // B_orderUP
            // 
            this.B_orderUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_orderUP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUP.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_orderUP.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUP.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUP.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_orderUP.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUP.Location = new System.Drawing.Point(258, 372);
            this.B_orderUP.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_orderUP.Name = "B_orderUP";
            this.B_orderUP.RectColor = System.Drawing.Color.White;
            this.B_orderUP.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_orderUP.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUP.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUP.Size = new System.Drawing.Size(87, 35);
            this.B_orderUP.Style = Sunny.UI.UIStyle.Custom;
            this.B_orderUP.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUP.TabIndex = 35;
            this.B_orderUP.Text = "수정";
            this.B_orderUP.Click += new System.EventHandler(this.B_orderUP_Click);
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel10.Location = new System.Drawing.Point(40, 190);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 31);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 27;
            this.uiLabel10.Text = "자재명";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel6.Location = new System.Drawing.Point(440, 136);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 31);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 31;
            this.uiLabel6.Text = "점주명";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel2.Location = new System.Drawing.Point(40, 135);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 31);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 32;
            this.uiLabel2.Text = "지점코드";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel5.Location = new System.Drawing.Point(245, 136);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 31);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 33;
            this.uiLabel5.Text = "지점명";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(263, 34);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61508;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.TabIndex = 20;
            this.uiSymbolLabel3.Text = "주문정보 수정";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(253, 190);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 31);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 27;
            this.uiLabel1.Text = "개수";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_branchcodeUp
            // 
            this.L_branchcodeUp.BackColor = System.Drawing.Color.White;
            this.L_branchcodeUp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.L_branchcodeUp.Location = new System.Drawing.Point(139, 139);
            this.L_branchcodeUp.Name = "L_branchcodeUp";
            this.L_branchcodeUp.Size = new System.Drawing.Size(100, 23);
            this.L_branchcodeUp.TabIndex = 36;
            this.L_branchcodeUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_branchnameUp
            // 
            this.L_branchnameUp.BackColor = System.Drawing.Color.White;
            this.L_branchnameUp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.L_branchnameUp.Location = new System.Drawing.Point(333, 139);
            this.L_branchnameUp.Name = "L_branchnameUp";
            this.L_branchnameUp.Size = new System.Drawing.Size(100, 23);
            this.L_branchnameUp.TabIndex = 36;
            this.L_branchnameUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_nameUp
            // 
            this.L_nameUp.BackColor = System.Drawing.Color.White;
            this.L_nameUp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.L_nameUp.Location = new System.Drawing.Point(533, 140);
            this.L_nameUp.Name = "L_nameUp";
            this.L_nameUp.Size = new System.Drawing.Size(100, 23);
            this.L_nameUp.TabIndex = 36;
            this.L_nameUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_materialnameUp
            // 
            this.L_materialnameUp.BackColor = System.Drawing.Color.White;
            this.L_materialnameUp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.L_materialnameUp.Location = new System.Drawing.Point(139, 198);
            this.L_materialnameUp.Name = "L_materialnameUp";
            this.L_materialnameUp.Size = new System.Drawing.Size(100, 23);
            this.L_materialnameUp.TabIndex = 36;
            this.L_materialnameUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_materialcountUp
            // 
            this.L_materialcountUp.BackColor = System.Drawing.Color.White;
            this.L_materialcountUp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.L_materialcountUp.Location = new System.Drawing.Point(333, 194);
            this.L_materialcountUp.Name = "L_materialcountUp";
            this.L_materialcountUp.Size = new System.Drawing.Size(100, 23);
            this.L_materialcountUp.TabIndex = 36;
            this.L_materialcountUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(143, 265);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(129, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 261683;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 37;
            this.uiSymbolLabel1.Text = "주문상태";
            // 
            // C_statusUp
            // 
            this.C_statusUp.DataSource = null;
            this.C_statusUp.FillColor = System.Drawing.Color.White;
            this.C_statusUp.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_statusUp.Items.AddRange(new object[] {
            "주문완료",
            "출고완료"});
            this.C_statusUp.Location = new System.Drawing.Point(288, 271);
            this.C_statusUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C_statusUp.MinimumSize = new System.Drawing.Size(63, 0);
            this.C_statusUp.Name = "C_statusUp";
            this.C_statusUp.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.C_statusUp.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.C_statusUp.Size = new System.Drawing.Size(188, 29);
            this.C_statusUp.Style = Sunny.UI.UIStyle.Custom;
            this.C_statusUp.TabIndex = 38;
            this.C_statusUp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.C_statusUp.Watermark = "";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(143, 304);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Size = new System.Drawing.Size(129, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 61649;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.TabIndex = 37;
            this.uiSymbolLabel2.Text = "송장번호";
            // 
            // T_wayUp
            // 
            this.T_wayUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_wayUp.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_wayUp.Location = new System.Drawing.Point(289, 309);
            this.T_wayUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_wayUp.MinimumSize = new System.Drawing.Size(1, 16);
            this.T_wayUp.Name = "T_wayUp";
            this.T_wayUp.Padding = new System.Windows.Forms.Padding(5);
            this.T_wayUp.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_wayUp.ShowText = false;
            this.T_wayUp.Size = new System.Drawing.Size(187, 29);
            this.T_wayUp.Style = Sunny.UI.UIStyle.Custom;
            this.T_wayUp.TabIndex = 39;
            this.T_wayUp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.T_wayUp.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel3.Location = new System.Drawing.Point(40, 84);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 31);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 32;
            this.uiLabel3.Text = "주문번호";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_ordercodeUp
            // 
            this.L_ordercodeUp.BackColor = System.Drawing.Color.White;
            this.L_ordercodeUp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.L_ordercodeUp.Location = new System.Drawing.Point(139, 88);
            this.L_ordercodeUp.Name = "L_ordercodeUp";
            this.L_ordercodeUp.Size = new System.Drawing.Size(100, 23);
            this.L_ordercodeUp.TabIndex = 36;
            this.L_ordercodeUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.T_wayUp);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.C_statusUp);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.L_materialcountUp);
            this.Controls.Add(this.L_materialnameUp);
            this.Controls.Add(this.L_nameUp);
            this.Controls.Add(this.L_branchnameUp);
            this.Controls.Add(this.L_ordercodeUp);
            this.Controls.Add(this.L_branchcodeUp);
            this.Controls.Add(this.B_cancelUP);
            this.Controls.Add(this.B_orderUP);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Name = "OrderUpdate";
            this.Size = new System.Drawing.Size(678, 508);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton B_cancelUP;
        private Sunny.UI.UISymbolButton B_orderUP;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel L_branchcodeUp;
        private Sunny.UI.UILabel L_branchnameUp;
        private Sunny.UI.UILabel L_nameUp;
        private Sunny.UI.UILabel L_materialnameUp;
        private Sunny.UI.UILabel L_materialcountUp;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox C_statusUp;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox T_wayUp;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel L_ordercodeUp;
    }
}
