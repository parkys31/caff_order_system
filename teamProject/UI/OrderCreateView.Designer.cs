namespace teamProject.UI
{
    partial class OrderCreateView
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
            this.materialList = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.count = new Sunny.UI.UITextBox();
            this.orderSave = new Sunny.UI.UISymbolButton();
            this.modifyButton = new Sunny.UI.UISymbolButton();
            this.cancel = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // materialList
            // 
            this.materialList.DataSource = null;
            this.materialList.FillColor = System.Drawing.Color.White;
            this.materialList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialList.Location = new System.Drawing.Point(285, 150);
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
            this.uiLabel2.Location = new System.Drawing.Point(178, 156);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "신청품목";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(178, 194);
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
            this.count.Location = new System.Drawing.Point(285, 194);
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
            this.orderSave.Location = new System.Drawing.Point(203, 260);
            this.orderSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderSave.Name = "orderSave";
            this.orderSave.Size = new System.Drawing.Size(100, 35);
            this.orderSave.Symbol = 361639;
            this.orderSave.TabIndex = 5;
            this.orderSave.Text = "등록";
            this.orderSave.Visible = false;
            this.orderSave.Click += new System.EventHandler(this.orderSave_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modifyButton.Location = new System.Drawing.Point(203, 260);
            this.modifyButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(100, 35);
            this.modifyButton.Symbol = 361639;
            this.modifyButton.TabIndex = 6;
            this.modifyButton.Text = "수정";
            this.modifyButton.Visible = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cancel.Location = new System.Drawing.Point(335, 260);
            this.cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 35);
            this.cancel.Symbol = 361639;
            this.cancel.TabIndex = 7;
            this.cancel.Text = "취소";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // OrderCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.orderSave);
            this.Controls.Add(this.count);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.materialList);
            this.Name = "OrderCreateView";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIComboBox materialList;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox count;
        private Sunny.UI.UISymbolButton orderSave;
        private Sunny.UI.UISymbolButton modifyButton;
        private Sunny.UI.UISymbolButton cancel;
    }
}
