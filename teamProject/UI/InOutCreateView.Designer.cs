namespace teamProject.UI
{
    partial class InOutCreateView
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
            this.cancel = new Sunny.UI.UISymbolButton();
            this.modifyButton = new Sunny.UI.UISymbolButton();
            this.count = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.materialList = new Sunny.UI.UIComboBox();
            this.inRadio = new Sunny.UI.UIRadioButton();
            this.outRadio = new Sunny.UI.UIRadioButton();
            this.createButton = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cancel.Location = new System.Drawing.Point(338, 289);
            this.cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 35);
            this.cancel.Symbol = 361639;
            this.cancel.TabIndex = 14;
            this.cancel.Text = "취소";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modifyButton.Location = new System.Drawing.Point(206, 289);
            this.modifyButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(100, 35);
            this.modifyButton.Symbol = 361639;
            this.modifyButton.TabIndex = 13;
            this.modifyButton.Text = "수정";
            this.modifyButton.Visible = false;
            this.modifyButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // count
            // 
            this.count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.count.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.count.Location = new System.Drawing.Point(288, 198);
            this.count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.count.MinimumSize = new System.Drawing.Size(1, 16);
            this.count.Name = "count";
            this.count.Padding = new System.Windows.Forms.Padding(5);
            this.count.ShowText = false;
            this.count.Size = new System.Drawing.Size(150, 29);
            this.count.TabIndex = 11;
            this.count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.count.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(181, 198);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 10;
            this.uiLabel3.Text = "입출고개수";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(181, 160);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "임출고품목";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialList
            // 
            this.materialList.DataSource = null;
            this.materialList.FillColor = System.Drawing.Color.White;
            this.materialList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialList.Location = new System.Drawing.Point(288, 154);
            this.materialList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialList.MinimumSize = new System.Drawing.Size(63, 0);
            this.materialList.Name = "materialList";
            this.materialList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.materialList.Size = new System.Drawing.Size(150, 29);
            this.materialList.TabIndex = 8;
            this.materialList.Text = "자재 선택";
            this.materialList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialList.Watermark = "";
            // 
            // inRadio
            // 
            this.inRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inRadio.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.inRadio.Location = new System.Drawing.Point(288, 245);
            this.inRadio.MinimumSize = new System.Drawing.Size(1, 1);
            this.inRadio.Name = "inRadio";
            this.inRadio.Size = new System.Drawing.Size(66, 29);
            this.inRadio.TabIndex = 15;
            this.inRadio.Text = "입고";
            this.inRadio.CheckedChanged += new System.EventHandler(this.inOutCheckedChanged);
            // 
            // outRadio
            // 
            this.outRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outRadio.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.outRadio.Location = new System.Drawing.Point(372, 245);
            this.outRadio.MinimumSize = new System.Drawing.Size(1, 1);
            this.outRadio.Name = "outRadio";
            this.outRadio.Size = new System.Drawing.Size(66, 29);
            this.outRadio.TabIndex = 16;
            this.outRadio.Text = "출고";
            this.outRadio.CheckedChanged += new System.EventHandler(this.inOutCheckedChanged);
            // 
            // createButton
            // 
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createButton.Location = new System.Drawing.Point(206, 289);
            this.createButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 35);
            this.createButton.Symbol = 361639;
            this.createButton.TabIndex = 12;
            this.createButton.Text = "등록";
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // InOutCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outRadio);
            this.Controls.Add(this.inRadio);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.count);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.materialList);
            this.Name = "InOutCreateView";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.InOutCreateView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton cancel;
        private Sunny.UI.UISymbolButton modifyButton;
        private Sunny.UI.UITextBox count;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox materialList;
        private Sunny.UI.UIRadioButton inRadio;
        private Sunny.UI.UIRadioButton outRadio;
        private Sunny.UI.UISymbolButton createButton;
    }
}
