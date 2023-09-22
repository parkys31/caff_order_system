namespace teamProject.UI
{
    partial class MaterialListView
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
            this.materialList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.searchText = new Sunny.UI.UITextBox();
            this.searchButton = new Sunny.UI.UIButton();
            this.modifiedButton = new Sunny.UI.UIButton();
            this.deleteButton = new Sunny.UI.UIButton();
            this.createButton = new Sunny.UI.UIButton();
            this.materialCode = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // materialList
            // 
            this.materialList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.materialList.FullRowSelect = true;
            this.materialList.HideSelection = false;
            this.materialList.Location = new System.Drawing.Point(28, 144);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(622, 339);
            this.materialList.TabIndex = 7;
            this.materialList.UseCompatibleStateImageBehavior = false;
            this.materialList.View = System.Windows.Forms.View.Details;
            this.materialList.SelectedIndexChanged += new System.EventHandler(this.materialList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "자재명";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "개수";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "자재코드";
            this.columnHeader3.Width = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.uiLabel1.Location = new System.Drawing.Point(49, 26);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(333, 52);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "재고 현황";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchText
            // 
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchText.Location = new System.Drawing.Point(28, 101);
            this.searchText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchText.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchText.Name = "searchText";
            this.searchText.Padding = new System.Windows.Forms.Padding(5);
            this.searchText.ShowText = false;
            this.searchText.Size = new System.Drawing.Size(190, 35);
            this.searchText.TabIndex = 12;
            this.searchText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchText.Watermark = "";
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchButton.Location = new System.Drawing.Point(225, 101);
            this.searchButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(69, 35);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "검색";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // modifiedButton
            // 
            this.modifiedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifiedButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modifiedButton.Location = new System.Drawing.Point(506, 101);
            this.modifiedButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.modifiedButton.Name = "modifiedButton";
            this.modifiedButton.Size = new System.Drawing.Size(69, 35);
            this.modifiedButton.TabIndex = 9;
            this.modifiedButton.Text = "수정";
            this.modifiedButton.Click += new System.EventHandler(this.modifiedButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deleteButton.Location = new System.Drawing.Point(581, 101);
            this.deleteButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(69, 35);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "삭제";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createButton.Location = new System.Drawing.Point(431, 101);
            this.createButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(69, 35);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "등록";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // materialCode
            // 
            this.materialCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialCode.Location = new System.Drawing.Point(346, 101);
            this.materialCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialCode.Name = "materialCode";
            this.materialCode.Size = new System.Drawing.Size(79, 35);
            this.materialCode.TabIndex = 16;
            this.materialCode.Text = "자재코드";
            this.materialCode.Visible = false;
            this.materialCode.Click += new System.EventHandler(this.materialCode_Click);
            // 
            // MaterialListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCode);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.materialList);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.modifiedButton);
            this.Name = "MaterialListView";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.MaterialListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView materialList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox searchText;
        private Sunny.UI.UIButton searchButton;
        private Sunny.UI.UIButton modifiedButton;
        private Sunny.UI.UIButton deleteButton;
        private Sunny.UI.UIButton createButton;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Sunny.UI.UIButton materialCode;
    }
}
