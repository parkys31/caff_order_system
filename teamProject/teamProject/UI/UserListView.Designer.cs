namespace teamProject.UI
{
    partial class UserListView
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
            this.userManagementList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.userIdTextBox = new Sunny.UI.UITextBox();
            this.userPwTextBox = new Sunny.UI.UITextBox();
            this.insertButton = new Sunny.UI.UIButton();
            this.deleteButton = new Sunny.UI.UIButton();
            this.branchList = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // userManagementList
            // 
            this.userManagementList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.userManagementList.FullRowSelect = true;
            this.userManagementList.HideSelection = false;
            this.userManagementList.Location = new System.Drawing.Point(52, 127);
            this.userManagementList.Name = "userManagementList";
            this.userManagementList.Size = new System.Drawing.Size(428, 338);
            this.userManagementList.TabIndex = 0;
            this.userManagementList.UseCompatibleStateImageBehavior = false;
            this.userManagementList.View = System.Windows.Forms.View.Details;
            this.userManagementList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.userList_ColumnClick);
            this.userManagementList.SelectedIndexChanged += new System.EventHandler(this.userManagementList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "유저 아이디";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "유저 패스워드";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "지점";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "지점코드";
            this.columnHeader4.Width = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(52, 36);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(404, 78);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "유저리스트";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userIdTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.userIdTextBox.Location = new System.Drawing.Point(500, 158);
            this.userIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userIdTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.userIdTextBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userIdTextBox.ShowText = false;
            this.userIdTextBox.Size = new System.Drawing.Size(150, 29);
            this.userIdTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.userIdTextBox.TabIndex = 2;
            this.userIdTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.userIdTextBox.Watermark = "";
            // 
            // userPwTextBox
            // 
            this.userPwTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPwTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.userPwTextBox.Location = new System.Drawing.Point(500, 222);
            this.userPwTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userPwTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.userPwTextBox.Name = "userPwTextBox";
            this.userPwTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.userPwTextBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userPwTextBox.ShowText = false;
            this.userPwTextBox.Size = new System.Drawing.Size(150, 29);
            this.userPwTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.userPwTextBox.TabIndex = 3;
            this.userPwTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.userPwTextBox.Watermark = "";
            // 
            // insertButton
            // 
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.insertButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.Location = new System.Drawing.Point(500, 323);
            this.insertButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertButton.Name = "insertButton";
            this.insertButton.RectColor = System.Drawing.Color.White;
            this.insertButton.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.insertButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.Size = new System.Drawing.Size(69, 45);
            this.insertButton.Style = Sunny.UI.UIStyle.Custom;
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "등록";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.deleteButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.Location = new System.Drawing.Point(581, 323);
            this.deleteButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.RectColor = System.Drawing.Color.White;
            this.deleteButton.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.deleteButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.Size = new System.Drawing.Size(69, 45);
            this.deleteButton.Style = Sunny.UI.UIStyle.Custom;
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "삭제";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // branchList
            // 
            this.branchList.DataSource = null;
            this.branchList.FillColor = System.Drawing.Color.White;
            this.branchList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.branchList.Location = new System.Drawing.Point(500, 286);
            this.branchList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.branchList.MinimumSize = new System.Drawing.Size(63, 0);
            this.branchList.Name = "branchList";
            this.branchList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.branchList.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.branchList.Size = new System.Drawing.Size(150, 29);
            this.branchList.Style = Sunny.UI.UIStyle.Custom;
            this.branchList.TabIndex = 6;
            this.branchList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.branchList.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel2.Location = new System.Drawing.Point(496, 127);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "유저 아이디";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel3.Location = new System.Drawing.Point(496, 194);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "유저 패스워드";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel4.Location = new System.Drawing.Point(496, 256);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "담당 지점";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.branchList);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.userPwTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.userManagementList);
            this.Name = "UserListView";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.UserListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView userManagementList;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Sunny.UI.UITextBox userIdTextBox;
        private Sunny.UI.UITextBox userPwTextBox;
        private Sunny.UI.UIButton insertButton;
        private Sunny.UI.UIButton deleteButton;
        private Sunny.UI.UIComboBox branchList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
    }
}
