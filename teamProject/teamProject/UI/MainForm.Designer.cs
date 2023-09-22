namespace teamProject.UI
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutButton = new Sunny.UI.UIButton();
            this.title = new Sunny.UI.UISymbolLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.branch = new Sunny.UI.UISymbolButton();
            this.user = new Sunny.UI.UISymbolButton();
            this.inOut = new Sunny.UI.UISymbolButton();
            this.materialList = new Sunny.UI.UISymbolButton();
            this.orderList = new Sunny.UI.UISymbolButton();
            this.order = new Sunny.UI.UISymbolButton();
            this.home = new Sunny.UI.UISymbolButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Location = new System.Drawing.Point(150, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 508);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 108);
            this.panel2.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FillColor = System.Drawing.Color.LemonChiffon;
            this.logoutButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.logoutButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.logoutButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.logoutButton.Font = new System.Drawing.Font("티웨이_항공", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.logoutButton.Location = new System.Drawing.Point(745, 75);
            this.logoutButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.RectColor = System.Drawing.Color.Transparent;
            this.logoutButton.RectHoverColor = System.Drawing.Color.Transparent;
            this.logoutButton.RectPressColor = System.Drawing.Color.Transparent;
            this.logoutButton.Size = new System.Drawing.Size(83, 34);
            this.logoutButton.Style = Sunny.UI.UIStyle.Custom;
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // title
            // 
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.LemonChiffon;
            this.title.Location = new System.Drawing.Point(183, 12);
            this.title.MinimumSize = new System.Drawing.Size(1, 1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(586, 74);
            this.title.Style = Sunny.UI.UIStyle.Custom;
            this.title.Symbol = 57564;
            this.title.SymbolColor = System.Drawing.Color.White;
            this.title.SymbolOffset = new System.Drawing.Point(0, 4);
            this.title.SymbolSize = 70;
            this.title.TabIndex = 0;
            this.title.Text = "Coffee Other System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel3.Controls.Add(this.branch);
            this.panel3.Controls.Add(this.user);
            this.panel3.Controls.Add(this.inOut);
            this.panel3.Controls.Add(this.materialList);
            this.panel3.Controls.Add(this.orderList);
            this.panel3.Controls.Add(this.order);
            this.panel3.Controls.Add(this.home);
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 511);
            this.panel3.TabIndex = 1;
            // 
            // branch
            // 
            this.branch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.branch.FillColor = System.Drawing.Color.White;
            this.branch.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.branch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branch.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branch.Font = new System.Drawing.Font("티웨이_항공", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.branch.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.branch.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branch.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.branch.Location = new System.Drawing.Point(3, 71);
            this.branch.MinimumSize = new System.Drawing.Size(1, 1);
            this.branch.Name = "branch";
            this.branch.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.branch.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.branch.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branch.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branch.Size = new System.Drawing.Size(141, 59);
            this.branch.Style = Sunny.UI.UIStyle.Custom;
            this.branch.Symbol = 57588;
            this.branch.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.branch.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branch.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branch.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branch.TabIndex = 4;
            this.branch.Text = "지점관리";
            this.branch.Visible = false;
            this.branch.Click += new System.EventHandler(this.branch_Click);
            // 
            // user
            // 
            this.user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user.FillColor = System.Drawing.Color.White;
            this.user.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.user.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.user.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.user.Font = new System.Drawing.Font("티웨이_항공", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.user.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.user.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.user.Location = new System.Drawing.Point(3, 331);
            this.user.MinimumSize = new System.Drawing.Size(1, 1);
            this.user.Name = "user";
            this.user.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.user.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.user.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.user.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.user.Size = new System.Drawing.Size(141, 59);
            this.user.Style = Sunny.UI.UIStyle.Custom;
            this.user.Symbol = 62141;
            this.user.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.user.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.user.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.user.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.user.TabIndex = 7;
            this.user.Text = "유저관리";
            this.user.Visible = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // inOut
            // 
            this.inOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inOut.FillColor = System.Drawing.Color.White;
            this.inOut.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.inOut.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inOut.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inOut.Font = new System.Drawing.Font("티웨이_항공", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inOut.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.inOut.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inOut.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.inOut.Location = new System.Drawing.Point(3, 266);
            this.inOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.inOut.Name = "inOut";
            this.inOut.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.inOut.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.inOut.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inOut.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inOut.Size = new System.Drawing.Size(141, 59);
            this.inOut.Style = Sunny.UI.UIStyle.Custom;
            this.inOut.Symbol = 362877;
            this.inOut.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.inOut.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inOut.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inOut.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inOut.TabIndex = 5;
            this.inOut.Text = "입출고관리";
            this.inOut.Visible = false;
            this.inOut.Click += new System.EventHandler(this.inOut_Click);
            // 
            // materialList
            // 
            this.materialList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialList.FillColor = System.Drawing.Color.White;
            this.materialList.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.materialList.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialList.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialList.Font = new System.Drawing.Font("티웨이_항공", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.materialList.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.materialList.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialList.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.materialList.Location = new System.Drawing.Point(3, 201);
            this.materialList.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialList.Name = "materialList";
            this.materialList.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.materialList.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.materialList.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialList.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialList.Size = new System.Drawing.Size(141, 59);
            this.materialList.Style = Sunny.UI.UIStyle.Custom;
            this.materialList.Symbol = 362566;
            this.materialList.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.materialList.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialList.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialList.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialList.TabIndex = 3;
            this.materialList.Text = "재고확인";
            this.materialList.Visible = false;
            this.materialList.Click += new System.EventHandler(this.materialList_Click);
            // 
            // orderList
            // 
            this.orderList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderList.FillColor = System.Drawing.Color.White;
            this.orderList.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.orderList.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderList.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderList.Font = new System.Drawing.Font("티웨이_항공", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderList.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.orderList.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderList.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.orderList.Location = new System.Drawing.Point(3, 136);
            this.orderList.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderList.Name = "orderList";
            this.orderList.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.orderList.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.orderList.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderList.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderList.Size = new System.Drawing.Size(141, 59);
            this.orderList.Style = Sunny.UI.UIStyle.Custom;
            this.orderList.Symbol = 61451;
            this.orderList.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.orderList.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderList.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderList.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderList.TabIndex = 2;
            this.orderList.Text = "발주현황";
            this.orderList.Visible = false;
            this.orderList.Click += new System.EventHandler(this.orderList_Click);
            // 
            // order
            // 
            this.order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order.FillColor = System.Drawing.Color.White;
            this.order.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.order.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.order.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.order.Font = new System.Drawing.Font("티웨이_항공", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.order.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.order.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.order.Location = new System.Drawing.Point(3, 71);
            this.order.MinimumSize = new System.Drawing.Size(1, 1);
            this.order.Name = "order";
            this.order.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.order.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.order.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.order.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.order.Size = new System.Drawing.Size(141, 59);
            this.order.Style = Sunny.UI.UIStyle.Custom;
            this.order.Symbol = 362573;
            this.order.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.order.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.order.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.order.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.order.TabIndex = 1;
            this.order.Text = "발주신청";
            this.order.Visible = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // home
            // 
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.FillColor = System.Drawing.Color.White;
            this.home.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.home.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.home.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.home.Font = new System.Drawing.Font("티웨이_항공", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.home.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.home.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.home.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.home.Location = new System.Drawing.Point(3, 6);
            this.home.MinimumSize = new System.Drawing.Size(1, 1);
            this.home.Name = "home";
            this.home.RectColor = System.Drawing.Color.DarkSeaGreen;
            this.home.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.home.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.home.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.home.Size = new System.Drawing.Size(141, 59);
            this.home.Style = Sunny.UI.UIStyle.Custom;
            this.home.Symbol = 61461;
            this.home.SymbolColor = System.Drawing.Color.DarkSeaGreen;
            this.home.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.home.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.home.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.home.TabIndex = 0;
            this.home.Text = "메인";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UISymbolLabel title;
        private Sunny.UI.UISymbolButton materialList;
        private Sunny.UI.UISymbolButton orderList;
        private Sunny.UI.UISymbolButton order;
        private Sunny.UI.UISymbolButton home;
        private Sunny.UI.UISymbolButton branch;
        private Sunny.UI.UISymbolButton inOut;
        private Sunny.UI.UISymbolButton user;
        private Sunny.UI.UIButton logoutButton;
    }
}

