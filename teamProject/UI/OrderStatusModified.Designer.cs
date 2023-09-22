namespace teamProject.UI
{
    partial class OrderStatusModified
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.materialNameText = new Sunny.UI.UITextBox();
            this.countText = new Sunny.UI.UITextBox();
            this.waybillText = new Sunny.UI.UITextBox();
            this.shippingRadioButton = new Sunny.UI.UIRadioButton();
            this.endRadioButton = new Sunny.UI.UIRadioButton();
            this.label5 = new Sunny.UI.UILabel();
            this.label6 = new Sunny.UI.UILabel();
            this.updateButton = new Sunny.UI.UIButton();
            this.cancelButton = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(205, 115);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(88, 29);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "재료명";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(205, 150);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(88, 29);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "개수";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(205, 189);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(88, 29);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "발주현황";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(205, 228);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(88, 29);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "운송장번호";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialNameText
            // 
            this.materialNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialNameText.Enabled = false;
            this.materialNameText.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialNameText.Location = new System.Drawing.Point(300, 115);
            this.materialNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialNameText.MinimumSize = new System.Drawing.Size(1, 16);
            this.materialNameText.Name = "materialNameText";
            this.materialNameText.Padding = new System.Windows.Forms.Padding(5);
            this.materialNameText.ShowText = false;
            this.materialNameText.Size = new System.Drawing.Size(150, 29);
            this.materialNameText.TabIndex = 4;
            this.materialNameText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialNameText.Watermark = "";
            // 
            // countText
            // 
            this.countText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countText.Enabled = false;
            this.countText.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.countText.Location = new System.Drawing.Point(300, 150);
            this.countText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countText.MinimumSize = new System.Drawing.Size(1, 16);
            this.countText.Name = "countText";
            this.countText.Padding = new System.Windows.Forms.Padding(5);
            this.countText.ShowText = false;
            this.countText.Size = new System.Drawing.Size(150, 29);
            this.countText.TabIndex = 5;
            this.countText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.countText.Watermark = "";
            // 
            // waybillText
            // 
            this.waybillText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.waybillText.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.waybillText.Location = new System.Drawing.Point(300, 228);
            this.waybillText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.waybillText.MinimumSize = new System.Drawing.Size(1, 16);
            this.waybillText.Name = "waybillText";
            this.waybillText.Padding = new System.Windows.Forms.Padding(5);
            this.waybillText.ShowText = false;
            this.waybillText.Size = new System.Drawing.Size(150, 29);
            this.waybillText.TabIndex = 5;
            this.waybillText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.waybillText.Watermark = "";
            // 
            // shippingRadioButton
            // 
            this.shippingRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shippingRadioButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.shippingRadioButton.Location = new System.Drawing.Point(300, 191);
            this.shippingRadioButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.shippingRadioButton.Name = "shippingRadioButton";
            this.shippingRadioButton.Size = new System.Drawing.Size(25, 29);
            this.shippingRadioButton.TabIndex = 6;
            this.shippingRadioButton.Text = "uiRadioButton1";
            this.shippingRadioButton.CheckedChanged += new System.EventHandler(this.uiRadioButton1_CheckedChanged);
            // 
            // endRadioButton
            // 
            this.endRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endRadioButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.endRadioButton.Location = new System.Drawing.Point(400, 191);
            this.endRadioButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.endRadioButton.Name = "endRadioButton";
            this.endRadioButton.Size = new System.Drawing.Size(25, 29);
            this.endRadioButton.TabIndex = 7;
            this.endRadioButton.Text = "uiRadioButton2";
            this.endRadioButton.CheckedChanged += new System.EventHandler(this.uiRadioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(331, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "배송중";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.Location = new System.Drawing.Point(431, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "배송완료";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateButton
            // 
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateButton.Location = new System.Drawing.Point(247, 305);
            this.updateButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 35);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "저장";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cancelButton.Location = new System.Drawing.Point(353, 305);
            this.cancelButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 35);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "취소";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OrderStatusModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endRadioButton);
            this.Controls.Add(this.shippingRadioButton);
            this.Controls.Add(this.waybillText);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.materialNameText);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "OrderStatusModified";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.OrderStatusModified_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox materialNameText;
        private Sunny.UI.UITextBox countText;
        private Sunny.UI.UITextBox waybillText;
        private Sunny.UI.UIRadioButton shippingRadioButton;
        private Sunny.UI.UIRadioButton endRadioButton;
        private Sunny.UI.UILabel label5;
        private Sunny.UI.UILabel label6;
        private Sunny.UI.UIButton updateButton;
        private Sunny.UI.UIButton cancelButton;
    }
}
