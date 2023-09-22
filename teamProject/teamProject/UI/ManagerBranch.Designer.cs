using Sunny.UI;

namespace teamProject.UI
{
    partial class ManagerBranch
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
            this.C_branch = new Sunny.UI.UIComboBox();
            this.T_branch = new Sunny.UI.UITextBox();
            this.B_branchSearch = new Sunny.UI.UIButton();
            this.L_branchList = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.branchname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opendate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_branchAll = new Sunny.UI.UIButton();
            this.B_branchInsert = new Sunny.UI.UIButton();
            this.B_branchUp = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(15, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(87, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61869;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 1;
            this.uiSymbolLabel1.Text = "Branch";
            // 
            // C_branch
            // 
            this.C_branch.DataSource = null;
            this.C_branch.FillColor = System.Drawing.Color.White;
            this.C_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_branch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.C_branch.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.C_branch.Items.AddRange(new object[] {
            "지점명",
            "지점코드",
            "점주명",
            "주소"});
            this.C_branch.Location = new System.Drawing.Point(106, 12);
            this.C_branch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C_branch.MinimumSize = new System.Drawing.Size(63, 0);
            this.C_branch.Name = "C_branch";
            this.C_branch.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.C_branch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.C_branch.Size = new System.Drawing.Size(113, 35);
            this.C_branch.Style = Sunny.UI.UIStyle.Custom;
            this.C_branch.TabIndex = 2;
            this.C_branch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.C_branch.Watermark = "";
            // 
            // T_branch
            // 
            this.T_branch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_branch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_branch.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_branch.Location = new System.Drawing.Point(223, 12);
            this.T_branch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_branch.MinimumSize = new System.Drawing.Size(1, 16);
            this.T_branch.Name = "T_branch";
            this.T_branch.Padding = new System.Windows.Forms.Padding(5);
            this.T_branch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_branch.ShowText = false;
            this.T_branch.Size = new System.Drawing.Size(205, 35);
            this.T_branch.Style = Sunny.UI.UIStyle.Custom;
            this.T_branch.TabIndex = 3;
            this.T_branch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.T_branch.Watermark = "";
            // 
            // B_branchSearch
            // 
            this.B_branchSearch.BackColor = System.Drawing.Color.LemonChiffon;
            this.B_branchSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_branchSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchSearch.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchSearch.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.B_branchSearch.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchSearch.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.B_branchSearch.Location = new System.Drawing.Point(434, 12);
            this.B_branchSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_branchSearch.Name = "B_branchSearch";
            this.B_branchSearch.RectColor = System.Drawing.Color.White;
            this.B_branchSearch.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchSearch.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchSearch.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchSearch.Size = new System.Drawing.Size(57, 35);
            this.B_branchSearch.Style = Sunny.UI.UIStyle.Custom;
            this.B_branchSearch.TabIndex = 4;
            this.B_branchSearch.Text = "검색";
            this.B_branchSearch.Click += new System.EventHandler(this.B_branchSearch_Click);
            // 
            // L_branchList
            // 
            this.L_branchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.branchname,
            this.name,
            this.tel,
            this.addr,
            this.opendate});
            this.L_branchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_branchList.FullRowSelect = true;
            this.L_branchList.HideSelection = false;
            this.L_branchList.Location = new System.Drawing.Point(17, 57);
            this.L_branchList.Name = "L_branchList";
            this.L_branchList.Size = new System.Drawing.Size(644, 435);
            this.L_branchList.TabIndex = 5;
            this.L_branchList.UseCompatibleStateImageBehavior = false;
            this.L_branchList.View = System.Windows.Forms.View.Details;
            this.L_branchList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.managerBranchList_ColumnClick);
            // 
            // code
            // 
            this.code.Text = "코드";
            this.code.Width = 50;
            // 
            // branchname
            // 
            this.branchname.Text = "지점명";
            this.branchname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.branchname.Width = 70;
            // 
            // name
            // 
            this.name.Text = "점주명";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 70;
            // 
            // tel
            // 
            this.tel.Text = "전화번호";
            this.tel.Width = 120;
            // 
            // addr
            // 
            this.addr.Text = "주소";
            this.addr.Width = 180;
            // 
            // opendate
            // 
            this.opendate.Text = "오픈";
            this.opendate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.opendate.Width = 100;
            // 
            // B_branchAll
            // 
            this.B_branchAll.BackColor = System.Drawing.Color.LemonChiffon;
            this.B_branchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_branchAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchAll.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchAll.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchAll.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.B_branchAll.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchAll.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.B_branchAll.Location = new System.Drawing.Point(497, 12);
            this.B_branchAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_branchAll.Name = "B_branchAll";
            this.B_branchAll.RectColor = System.Drawing.Color.White;
            this.B_branchAll.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchAll.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchAll.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchAll.Size = new System.Drawing.Size(57, 35);
            this.B_branchAll.Style = Sunny.UI.UIStyle.Custom;
            this.B_branchAll.TabIndex = 4;
            this.B_branchAll.Text = "전체";
            this.B_branchAll.Click += new System.EventHandler(this.B_branchAll_Click);
            // 
            // B_branchInsert
            // 
            this.B_branchInsert.BackColor = System.Drawing.Color.LemonChiffon;
            this.B_branchInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_branchInsert.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsert.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchInsert.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsert.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.B_branchInsert.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsert.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.B_branchInsert.Location = new System.Drawing.Point(560, 12);
            this.B_branchInsert.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_branchInsert.Name = "B_branchInsert";
            this.B_branchInsert.RectColor = System.Drawing.Color.White;
            this.B_branchInsert.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchInsert.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsert.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchInsert.Size = new System.Drawing.Size(57, 35);
            this.B_branchInsert.Style = Sunny.UI.UIStyle.Custom;
            this.B_branchInsert.TabIndex = 4;
            this.B_branchInsert.Text = "등록";
            this.B_branchInsert.Click += new System.EventHandler(this.B_branchInsert_Click);
            // 
            // B_branchUp
            // 
            this.B_branchUp.BackColor = System.Drawing.Color.LemonChiffon;
            this.B_branchUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_branchUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchUp.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchUp.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchUp.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.B_branchUp.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchUp.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.B_branchUp.Location = new System.Drawing.Point(623, 12);
            this.B_branchUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_branchUp.Name = "B_branchUp";
            this.B_branchUp.RectColor = System.Drawing.Color.White;
            this.B_branchUp.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_branchUp.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchUp.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_branchUp.Size = new System.Drawing.Size(47, 35);
            this.B_branchUp.Style = Sunny.UI.UIStyle.Custom;
            this.B_branchUp.TabIndex = 9;
            this.B_branchUp.Text = "수정";
            this.B_branchUp.Click += new System.EventHandler(this.B_branchUp_Click);
            // 
            // ManagerBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.L_branchList);
            this.Controls.Add(this.B_branchInsert);
            this.Controls.Add(this.B_branchAll);
            this.Controls.Add(this.B_branchSearch);
            this.Controls.Add(this.T_branch);
            this.Controls.Add(this.C_branch);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.B_branchUp);
            this.Name = "ManagerBranch";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.Branch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox C_branch;
        private Sunny.UI.UITextBox T_branch;
        private Sunny.UI.UIButton B_branchSearch;
        private System.Windows.Forms.ListView L_branchList;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader branchname;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader addr;
        private System.Windows.Forms.ColumnHeader opendate;
        private Sunny.UI.UIButton B_branchAll;
        private Sunny.UI.UIButton B_branchInsert;
        private UIButton B_branchUp;
    }
}
