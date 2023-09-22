namespace teamProject.UI
{
    partial class InOutListView
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
            this.warehousingList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createButton = new Sunny.UI.UIButton();
            this.deleteButton = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.modifiedButton = new Sunny.UI.UIButton();
            this.searchButton = new Sunny.UI.UIButton();
            this.inRadioButton = new Sunny.UI.UIRadioButton();
            this.outRadioButton = new Sunny.UI.UIRadioButton();
            this.inOutRadioButton = new Sunny.UI.UIRadioButton();
            this.SuspendLayout();
            // 
            // warehousingList
            // 
            this.warehousingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.warehousingList.FullRowSelect = true;
            this.warehousingList.HideSelection = false;
            this.warehousingList.Location = new System.Drawing.Point(28, 144);
            this.warehousingList.Name = "warehousingList";
            this.warehousingList.Size = new System.Drawing.Size(622, 339);
            this.warehousingList.TabIndex = 17;
            this.warehousingList.UseCompatibleStateImageBehavior = false;
            this.warehousingList.View = System.Windows.Forms.View.Details;
            this.warehousingList.SelectedIndexChanged += new System.EventHandler(this.materialList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "등록번호";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "자재명";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "자재코드";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "개수";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "입출고구분";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "입출고날짜";
            this.columnHeader6.Width = 180;
            // 
            // createButton
            // 
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createButton.Location = new System.Drawing.Point(431, 101);
            this.createButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(69, 35);
            this.createButton.TabIndex = 23;
            this.createButton.Text = "등록";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deleteButton.Location = new System.Drawing.Point(581, 101);
            this.deleteButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(69, 35);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "삭제";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.uiLabel1.Location = new System.Drawing.Point(49, 26);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(333, 52);
            this.uiLabel1.TabIndex = 21;
            this.uiLabel1.Text = "입출고 현황";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifiedButton
            // 
            this.modifiedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifiedButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modifiedButton.Location = new System.Drawing.Point(506, 101);
            this.modifiedButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.modifiedButton.Name = "modifiedButton";
            this.modifiedButton.Size = new System.Drawing.Size(69, 35);
            this.modifiedButton.TabIndex = 18;
            this.modifiedButton.Text = "수정";
            this.modifiedButton.Click += new System.EventHandler(this.modifiedButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchButton.Location = new System.Drawing.Point(287, 101);
            this.searchButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(69, 35);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "검색";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // inRadioButton
            // 
            this.inRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inRadioButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.inRadioButton.Location = new System.Drawing.Point(28, 101);
            this.inRadioButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.inRadioButton.Name = "inRadioButton";
            this.inRadioButton.Size = new System.Drawing.Size(69, 35);
            this.inRadioButton.TabIndex = 24;
            this.inRadioButton.Text = "입고";
            this.inRadioButton.CheckedChanged += new System.EventHandler(this.inOutCheckedChanged);
            // 
            // outRadioButton
            // 
            this.outRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outRadioButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.outRadioButton.Location = new System.Drawing.Point(109, 101);
            this.outRadioButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.outRadioButton.Name = "outRadioButton";
            this.outRadioButton.Size = new System.Drawing.Size(69, 35);
            this.outRadioButton.TabIndex = 25;
            this.outRadioButton.Text = "출고";
            this.outRadioButton.CheckedChanged += new System.EventHandler(this.inOutCheckedChanged);
            // 
            // inOutRadioButton
            // 
            this.inOutRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.inOutRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inOutRadioButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.inOutRadioButton.Location = new System.Drawing.Point(190, 101);
            this.inOutRadioButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.inOutRadioButton.Name = "inOutRadioButton";
            this.inOutRadioButton.Size = new System.Drawing.Size(91, 35);
            this.inOutRadioButton.TabIndex = 26;
            this.inOutRadioButton.Text = "입/출고";
            this.inOutRadioButton.CheckedChanged += new System.EventHandler(this.inOutCheckedChanged);
            // 
            // InOutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inOutRadioButton);
            this.Controls.Add(this.outRadioButton);
            this.Controls.Add(this.inRadioButton);
            this.Controls.Add(this.warehousingList);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.modifiedButton);
            this.Name = "InOutList";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.InOutList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView warehousingList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Sunny.UI.UIButton createButton;
        private Sunny.UI.UIButton deleteButton;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton modifiedButton;
        private Sunny.UI.UIButton searchButton;
        private Sunny.UI.UIRadioButton inRadioButton;
        private Sunny.UI.UIRadioButton outRadioButton;
        private Sunny.UI.UIRadioButton inOutRadioButton;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
