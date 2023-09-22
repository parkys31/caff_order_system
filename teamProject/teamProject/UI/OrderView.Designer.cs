namespace teamProject.UI
{
    partial class OrderView
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.materialList = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.count = new Sunny.UI.UITextBox();
            this.orderSave = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(21, 4);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(145, 225);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "발주코드,지점코드,자재코드,개수,신청일자,발주현황,운송장코드";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialList
            // 
            this.materialList.DataSource = null;
            this.materialList.FillColor = System.Drawing.Color.White;
            this.materialList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialList.Location = new System.Drawing.Point(304, 162);
            this.materialList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialList.MinimumSize = new System.Drawing.Size(63, 0);
            this.materialList.Name = "materialList";
            this.materialList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.materialList.Size = new System.Drawing.Size(150, 29);
            this.materialList.TabIndex = 1;
            this.materialList.Text = "자재 선택";
            this.materialList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialList.Watermark = "";
            this.materialList.SelectedIndexChanged += new System.EventHandler(this.materialList_SelectedIndexChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(197, 168);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "신청품목";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(197, 206);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "신청 개수";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // count
            // 
            this.count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.count.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.count.Location = new System.Drawing.Point(304, 206);
            this.count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.count.MinimumSize = new System.Drawing.Size(1, 16);
            this.count.Name = "count";
            this.count.Padding = new System.Windows.Forms.Padding(5);
            this.count.ShowText = false;
            this.count.Size = new System.Drawing.Size(150, 29);
            this.count.TabIndex = 4;
            this.count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.count.Watermark = "";
            // 
            // orderSave
            // 
            this.orderSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderSave.Location = new System.Drawing.Point(270, 272);
            this.orderSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderSave.Name = "orderSave";
            this.orderSave.Size = new System.Drawing.Size(100, 35);
            this.orderSave.Symbol = 361639;
            this.orderSave.TabIndex = 5;
            this.orderSave.Text = "등록";
            this.orderSave.Click += new System.EventHandler(this.orderSave_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderSave);
            this.Controls.Add(this.count);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.materialList);
            this.Controls.Add(this.uiLabel1);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox materialList;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox count;
        private Sunny.UI.UISymbolButton orderSave;
    }
}
