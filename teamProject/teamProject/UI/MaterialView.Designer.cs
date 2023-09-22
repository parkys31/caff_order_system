namespace teamProject.UI
{
    partial class MaterialView
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
            this.modifyButton = new Sunny.UI.UISymbolButton();
            this.count = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.matyerialNameView = new Sunny.UI.UITextBox();
            this.materialCodeList = new Sunny.UI.UIComboBox();
            this.materialSave = new Sunny.UI.UISymbolButton();
            this.cancel = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // modifyButton
            // 
            this.modifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifyButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifyButton.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.modifyButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifyButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifyButton.Location = new System.Drawing.Point(234, 275);
            this.modifyButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.RectColor = System.Drawing.Color.White;
            this.modifyButton.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.modifyButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifyButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifyButton.Size = new System.Drawing.Size(100, 35);
            this.modifyButton.Style = Sunny.UI.UIStyle.Custom;
            this.modifyButton.Symbol = 361639;
            this.modifyButton.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modifyButton.TabIndex = 12;
            this.modifyButton.Text = "수정";
            this.modifyButton.Visible = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // count
            // 
            this.count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.count.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.count.Location = new System.Drawing.Point(303, 209);
            this.count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.count.MinimumSize = new System.Drawing.Size(1, 16);
            this.count.Name = "count";
            this.count.Padding = new System.Windows.Forms.Padding(5);
            this.count.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.count.ShowText = false;
            this.count.Size = new System.Drawing.Size(150, 29);
            this.count.Style = Sunny.UI.UIStyle.Custom;
            this.count.TabIndex = 10;
            this.count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.count.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel3.Location = new System.Drawing.Point(196, 209);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 29);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 9;
            this.uiLabel3.Text = "재고 개수";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel2.Location = new System.Drawing.Point(196, 165);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 29);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "재고명";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matyerialNameView
            // 
            this.matyerialNameView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matyerialNameView.Enabled = false;
            this.matyerialNameView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.matyerialNameView.Location = new System.Drawing.Point(303, 165);
            this.matyerialNameView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.matyerialNameView.MinimumSize = new System.Drawing.Size(1, 16);
            this.matyerialNameView.Name = "matyerialNameView";
            this.matyerialNameView.Padding = new System.Windows.Forms.Padding(5);
            this.matyerialNameView.ShowText = false;
            this.matyerialNameView.Size = new System.Drawing.Size(150, 29);
            this.matyerialNameView.Style = Sunny.UI.UIStyle.Custom;
            this.matyerialNameView.TabIndex = 13;
            this.matyerialNameView.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.matyerialNameView.Visible = false;
            this.matyerialNameView.Watermark = "";
            this.matyerialNameView.TextChanged += new System.EventHandler(this.matyerialNameView_TextChanged);
            // 
            // materialCodeList
            // 
            this.materialCodeList.DataSource = null;
            this.materialCodeList.FillColor = System.Drawing.Color.White;
            this.materialCodeList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialCodeList.Location = new System.Drawing.Point(303, 165);
            this.materialCodeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialCodeList.MinimumSize = new System.Drawing.Size(63, 0);
            this.materialCodeList.Name = "materialCodeList";
            this.materialCodeList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.materialCodeList.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialCodeList.Size = new System.Drawing.Size(150, 29);
            this.materialCodeList.Style = Sunny.UI.UIStyle.Custom;
            this.materialCodeList.TabIndex = 14;
            this.materialCodeList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialCodeList.Visible = false;
            this.materialCodeList.Watermark = "";
            // 
            // materialSave
            // 
            this.materialSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialSave.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.materialSave.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialSave.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSave.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialSave.Location = new System.Drawing.Point(234, 275);
            this.materialSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialSave.Name = "materialSave";
            this.materialSave.RectColor = System.Drawing.Color.White;
            this.materialSave.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.materialSave.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialSave.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialSave.Size = new System.Drawing.Size(100, 35);
            this.materialSave.Style = Sunny.UI.UIStyle.Custom;
            this.materialSave.Symbol = 361639;
            this.materialSave.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialSave.TabIndex = 11;
            this.materialSave.Text = "등록";
            this.materialSave.Visible = false;
            this.materialSave.Click += new System.EventHandler(this.materialSave_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancel.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.cancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancel.Location = new System.Drawing.Point(340, 275);
            this.cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cancel.Name = "cancel";
            this.cancel.RectColor = System.Drawing.Color.White;
            this.cancel.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.cancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancel.Size = new System.Drawing.Size(100, 35);
            this.cancel.Style = Sunny.UI.UIStyle.Custom;
            this.cancel.Symbol = 361639;
            this.cancel.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancel.TabIndex = 15;
            this.cancel.Text = "취소";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // MaterialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.matyerialNameView);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.materialSave);
            this.Controls.Add(this.count);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.materialCodeList);
            this.Name = "MaterialView";
            this.Size = new System.Drawing.Size(678, 508);
            this.Load += new System.EventHandler(this.MaterialView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton modifyButton;
        private Sunny.UI.UITextBox count;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox matyerialNameView;
        private Sunny.UI.UISymbolButton materialSave;
        private Sunny.UI.UIComboBox materialCodeList;
        private Sunny.UI.UISymbolButton cancel;
    }
}
