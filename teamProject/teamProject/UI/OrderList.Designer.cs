namespace teamProject.UI
{
    partial class OrderList
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
            this.L_orderList = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.branchCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.branchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waybill_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_orderAll = new Sunny.UI.UIButton();
            this.B_orderSearch = new Sunny.UI.UIButton();
            this.T_order = new Sunny.UI.UITextBox();
            this.C_order = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.B_orderUp = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // L_orderList
            // 
            this.L_orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.branchCode,
            this.branchName,
            this.name,
            this.tel,
            this.materialName,
            this.count,
            this.orderDate,
            this.orderStatus,
            this.waybill_code});
            this.L_orderList.FullRowSelect = true;
            this.L_orderList.HideSelection = false;
            this.L_orderList.Location = new System.Drawing.Point(7, 62);
            this.L_orderList.Name = "L_orderList";
            this.L_orderList.Size = new System.Drawing.Size(661, 435);
            this.L_orderList.TabIndex = 16;
            this.L_orderList.UseCompatibleStateImageBehavior = false;
            this.L_orderList.View = System.Windows.Forms.View.Details;
            this.L_orderList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.orderList_ColumnClick);
            // 
            // code
            // 
            this.code.Text = "발주코드";
            // 
            // branchCode
            // 
            this.branchCode.Text = "지점코드";
            this.branchCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // branchName
            // 
            this.branchName.Text = "지점명";
            this.branchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.Text = "점주명";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tel
            // 
            this.tel.Text = "전화번호";
            this.tel.Width = 80;
            // 
            // materialName
            // 
            this.materialName.Text = "자재명";
            this.materialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialName.Width = 80;
            // 
            // count
            // 
            this.count.Text = "개수";
            this.count.Width = 50;
            // 
            // orderDate
            // 
            this.orderDate.Text = "발주날짜";
            this.orderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderDate.Width = 80;
            // 
            // orderStatus
            // 
            this.orderStatus.Text = "상태";
            this.orderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // waybill_code
            // 
            this.waybill_code.Text = "운송번호";
            // 
            // B_orderAll
            // 
            this.B_orderAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_orderAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderAll.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_orderAll.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderAll.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_orderAll.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderAll.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.B_orderAll.ForeSelectedColor = System.Drawing.Color.LemonChiffon;
            this.B_orderAll.Location = new System.Drawing.Point(494, 14);
            this.B_orderAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_orderAll.Name = "B_orderAll";
            this.B_orderAll.RectColor = System.Drawing.Color.White;
            this.B_orderAll.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_orderAll.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderAll.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderAll.Size = new System.Drawing.Size(57, 35);
            this.B_orderAll.Style = Sunny.UI.UIStyle.Custom;
            this.B_orderAll.TabIndex = 14;
            this.B_orderAll.Text = "전체";
            this.B_orderAll.Click += new System.EventHandler(this.B_orderAll_Click);
            // 
            // B_orderSearch
            // 
            this.B_orderSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_orderSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderSearch.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_orderSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderSearch.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_orderSearch.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderSearch.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.B_orderSearch.ForeSelectedColor = System.Drawing.Color.LemonChiffon;
            this.B_orderSearch.Location = new System.Drawing.Point(432, 14);
            this.B_orderSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_orderSearch.Name = "B_orderSearch";
            this.B_orderSearch.RectColor = System.Drawing.Color.White;
            this.B_orderSearch.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_orderSearch.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderSearch.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderSearch.Size = new System.Drawing.Size(57, 35);
            this.B_orderSearch.Style = Sunny.UI.UIStyle.Custom;
            this.B_orderSearch.TabIndex = 15;
            this.B_orderSearch.Text = "검색";
            this.B_orderSearch.Click += new System.EventHandler(this.B_orderSearch_Click);
            // 
            // T_order
            // 
            this.T_order.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_order.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.T_order.Location = new System.Drawing.Point(220, 14);
            this.T_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_order.MinimumSize = new System.Drawing.Size(1, 16);
            this.T_order.Name = "T_order";
            this.T_order.Padding = new System.Windows.Forms.Padding(5);
            this.T_order.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_order.ShowText = false;
            this.T_order.Size = new System.Drawing.Size(205, 35);
            this.T_order.Style = Sunny.UI.UIStyle.Custom;
            this.T_order.TabIndex = 12;
            this.T_order.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.T_order.Watermark = "";
            // 
            // C_order
            // 
            this.C_order.DataSource = null;
            this.C_order.FillColor = System.Drawing.Color.White;
            this.C_order.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.C_order.Items.AddRange(new object[] {
            "지점명",
            "자재명"});
            this.C_order.Location = new System.Drawing.Point(103, 14);
            this.C_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C_order.MinimumSize = new System.Drawing.Size(63, 0);
            this.C_order.Name = "C_order";
            this.C_order.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.C_order.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.C_order.Size = new System.Drawing.Size(113, 35);
            this.C_order.Style = Sunny.UI.UIStyle.Custom;
            this.C_order.TabIndex = 11;
            this.C_order.Text = "항목선택";
            this.C_order.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.C_order.Watermark = "";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 14);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(87, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 261930;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 10;
            this.uiSymbolLabel1.Text = "Order";
            // 
            // B_orderUp
            // 
            this.B_orderUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_orderUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUp.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_orderUp.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUp.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_orderUp.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUp.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.B_orderUp.ForeSelectedColor = System.Drawing.Color.LemonChiffon;
            this.B_orderUp.Location = new System.Drawing.Point(611, 14);
            this.B_orderUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.B_orderUp.Name = "B_orderUp";
            this.B_orderUp.RectColor = System.Drawing.Color.White;
            this.B_orderUp.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.B_orderUp.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUp.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_orderUp.Size = new System.Drawing.Size(47, 35);
            this.B_orderUp.Style = Sunny.UI.UIStyle.Custom;
            this.B_orderUp.TabIndex = 17;
            this.B_orderUp.Text = "수정";
            this.B_orderUp.Click += new System.EventHandler(this.B_orderUp_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.L_orderList);
            this.Controls.Add(this.B_orderAll);
            this.Controls.Add(this.B_orderSearch);
            this.Controls.Add(this.T_order);
            this.Controls.Add(this.C_order);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.B_orderUp);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView L_orderList;
        private Sunny.UI.UIButton B_orderAll;
        private Sunny.UI.UIButton B_orderSearch;
        private Sunny.UI.UITextBox T_order;
        private Sunny.UI.UIComboBox C_order;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIButton B_orderUp;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader branchCode;
        private System.Windows.Forms.ColumnHeader branchName;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader materialName;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader orderDate;
        private System.Windows.Forms.ColumnHeader orderStatus;
        private System.Windows.Forms.ColumnHeader waybill_code;
    }
}
