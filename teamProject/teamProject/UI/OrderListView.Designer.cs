namespace teamProject.UI
{
    partial class OrderListView
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
            this.orderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchList = new Sunny.UI.UIComboBox();
            this.modifiedButton = new Sunny.UI.UIButton();
            this.deleteButton = new Sunny.UI.UIButton();
            this.searchButton = new Sunny.UI.UIButton();
            this.searchText = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.orderList.FullRowSelect = true;
            this.orderList.HideSelection = false;
            this.orderList.Location = new System.Drawing.Point(27, 143);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(622, 339);
            this.orderList.TabIndex = 0;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            this.orderList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.orderList_ColumnClick);
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.orderList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "발주번호";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "발주지점";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "재료";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "개수";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "발주현황";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "발주신청일";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "운송장번호";
            this.columnHeader7.Width = 100;
            // 
            // searchList
            // 
            this.searchList.DataSource = null;
            this.searchList.FillColor = System.Drawing.Color.White;
            this.searchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchList.Location = new System.Drawing.Point(27, 106);
            this.searchList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchList.MinimumSize = new System.Drawing.Size(63, 0);
            this.searchList.Name = "searchList";
            this.searchList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.searchList.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchList.Size = new System.Drawing.Size(100, 35);
            this.searchList.Style = Sunny.UI.UIStyle.Custom;
            this.searchList.TabIndex = 1;
            this.searchList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchList.Watermark = "";
            // 
            // modifiedButton
            // 
            this.modifiedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifiedButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifiedButton.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.modifiedButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifiedButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifiedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedButton.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifiedButton.Location = new System.Drawing.Point(506, 106);
            this.modifiedButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.modifiedButton.Name = "modifiedButton";
            this.modifiedButton.RectColor = System.Drawing.Color.White;
            this.modifiedButton.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.modifiedButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifiedButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifiedButton.Size = new System.Drawing.Size(69, 35);
            this.modifiedButton.Style = Sunny.UI.UIStyle.Custom;
            this.modifiedButton.TabIndex = 2;
            this.modifiedButton.Text = "수정";
            this.modifiedButton.Click += new System.EventHandler(this.modifiedButton_Click);
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
            this.deleteButton.Location = new System.Drawing.Point(581, 106);
            this.deleteButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.RectColor = System.Drawing.Color.White;
            this.deleteButton.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.deleteButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.Size = new System.Drawing.Size(69, 35);
            this.deleteButton.Style = Sunny.UI.UIStyle.Custom;
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "삭제";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.searchButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.Location = new System.Drawing.Point(344, 106);
            this.searchButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.RectColor = System.Drawing.Color.White;
            this.searchButton.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.searchButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.Size = new System.Drawing.Size(69, 35);
            this.searchButton.Style = Sunny.UI.UIStyle.Custom;
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "검색";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(135, 106);
            this.searchText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchText.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchText.Name = "searchText";
            this.searchText.Padding = new System.Windows.Forms.Padding(5);
            this.searchText.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchText.ShowText = false;
            this.searchText.Size = new System.Drawing.Size(202, 35);
            this.searchText.Style = Sunny.UI.UIStyle.Custom;
            this.searchText.TabIndex = 5;
            this.searchText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchText.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(48, 25);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(333, 52);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "발주 현황";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifiedButton);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.orderList);
            this.Name = "OrderListView";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.OrderListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView orderList;
        private Sunny.UI.UIComboBox searchList;
        private Sunny.UI.UIButton modifiedButton;
        private Sunny.UI.UIButton deleteButton;
        private Sunny.UI.UIButton searchButton;
        private Sunny.UI.UITextBox searchText;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
