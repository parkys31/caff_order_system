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
            this.title = new Sunny.UI.UISymbolLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.user = new Sunny.UI.UISymbolButton();
            this.inOut = new Sunny.UI.UISymbolButton();
            this.branch = new Sunny.UI.UISymbolButton();
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
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(150, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 508);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 108);
            this.panel2.TabIndex = 1;
            // 
            // title
            // 
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(199, 12);
            this.title.MinimumSize = new System.Drawing.Size(1, 1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(448, 74);
            this.title.Symbol = 57564;
            this.title.SymbolSize = 60;
            this.title.TabIndex = 0;
            this.title.Text = "커피 발주 시스템";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.user);
            this.panel3.Controls.Add(this.inOut);
            this.panel3.Controls.Add(this.branch);
            this.panel3.Controls.Add(this.materialList);
            this.panel3.Controls.Add(this.orderList);
            this.panel3.Controls.Add(this.order);
            this.panel3.Controls.Add(this.home);
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 511);
            this.panel3.TabIndex = 1;
            // 
            // user
            // 
            this.user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.user.Location = new System.Drawing.Point(3, 331);
            this.user.MinimumSize = new System.Drawing.Size(1, 1);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(141, 59);
            this.user.Symbol = 62141;
            this.user.TabIndex = 7;
            this.user.Text = "유저관리";
            this.user.Visible = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // inOut
            // 
            this.inOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inOut.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.inOut.Location = new System.Drawing.Point(3, 266);
            this.inOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.inOut.Name = "inOut";
            this.inOut.Size = new System.Drawing.Size(141, 59);
            this.inOut.Symbol = 362877;
            this.inOut.TabIndex = 5;
            this.inOut.Text = "입출고관리";
            this.inOut.Visible = false;
            this.inOut.Click += new System.EventHandler(this.inOut_Click);
            // 
            // branch
            // 
            this.branch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.branch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.branch.Location = new System.Drawing.Point(0, 71);
            this.branch.MinimumSize = new System.Drawing.Size(1, 1);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(141, 59);
            this.branch.Symbol = 57588;
            this.branch.TabIndex = 4;
            this.branch.Text = "지점관리";
            this.branch.Visible = false;
            this.branch.Click += new System.EventHandler(this.branch_Click);
            // 
            // materialList
            // 
            this.materialList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialList.Location = new System.Drawing.Point(3, 201);
            this.materialList.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(141, 59);
            this.materialList.Symbol = 362566;
            this.materialList.TabIndex = 3;
            this.materialList.Text = "재고확인";
            this.materialList.Visible = false;
            this.materialList.Click += new System.EventHandler(this.materialList_Click);
            // 
            // orderList
            // 
            this.orderList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderList.Location = new System.Drawing.Point(3, 136);
            this.orderList.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(141, 59);
            this.orderList.Symbol = 61451;
            this.orderList.TabIndex = 2;
            this.orderList.Text = "발주현황";
            this.orderList.Visible = false;
            this.orderList.Click += new System.EventHandler(this.orderList_Click);
            // 
            // order
            // 
            this.order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.order.Location = new System.Drawing.Point(3, 71);
            this.order.MinimumSize = new System.Drawing.Size(1, 1);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(141, 59);
            this.order.Symbol = 362573;
            this.order.TabIndex = 1;
            this.order.Text = "발주신청";
            this.order.Visible = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // home
            // 
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.home.Location = new System.Drawing.Point(3, 6);
            this.home.MinimumSize = new System.Drawing.Size(1, 1);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(141, 59);
            this.home.Symbol = 61461;
            this.home.TabIndex = 0;
            this.home.Text = "메인";
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
    }
}

