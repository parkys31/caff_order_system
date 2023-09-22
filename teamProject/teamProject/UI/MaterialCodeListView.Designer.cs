namespace teamProject.UI
{
    partial class MaterialCodeListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.materialCodeList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new Sunny.UI.UIButton();
            this.insertButton = new Sunny.UI.UIButton();
            this.materialCodeText = new Sunny.UI.UITextBox();
            this.materialNameText = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(117, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(303, 78);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "자재코드 리스트";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCodeList
            // 
            this.materialCodeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.materialCodeList.FullRowSelect = true;
            this.materialCodeList.HideSelection = false;
            this.materialCodeList.Location = new System.Drawing.Point(66, 100);
            this.materialCodeList.Name = "materialCodeList";
            this.materialCodeList.Size = new System.Drawing.Size(214, 338);
            this.materialCodeList.TabIndex = 7;
            this.materialCodeList.UseCompatibleStateImageBehavior = false;
            this.materialCodeList.View = System.Windows.Forms.View.Details;
            this.materialCodeList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.materialCodeList_ColumnClick);
            this.materialCodeList.SelectedIndexChanged += new System.EventHandler(this.userManagementList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "자재명";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "자재코드";
            this.columnHeader2.Width = 100;
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.deleteButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.deleteButton.Location = new System.Drawing.Point(387, 233);
            this.deleteButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.RectColor = System.Drawing.Color.White;
            this.deleteButton.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.deleteButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.Size = new System.Drawing.Size(69, 45);
            this.deleteButton.Style = Sunny.UI.UIStyle.Custom;
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "삭제";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.FillHoverColor = System.Drawing.Color.LemonChiffon;
            this.insertButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.ForePressColor = System.Drawing.Color.LemonChiffon;
            this.insertButton.Location = new System.Drawing.Point(306, 233);
            this.insertButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertButton.Name = "insertButton";
            this.insertButton.RectColor = System.Drawing.Color.White;
            this.insertButton.RectHoverColor = System.Drawing.Color.LemonChiffon;
            this.insertButton.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertButton.Size = new System.Drawing.Size(69, 45);
            this.insertButton.Style = Sunny.UI.UIStyle.Custom;
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "등록";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // materialCodeText
            // 
            this.materialCodeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialCodeText.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialCodeText.Location = new System.Drawing.Point(306, 196);
            this.materialCodeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialCodeText.MinimumSize = new System.Drawing.Size(1, 16);
            this.materialCodeText.Name = "materialCodeText";
            this.materialCodeText.Padding = new System.Windows.Forms.Padding(5);
            this.materialCodeText.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialCodeText.ShowText = false;
            this.materialCodeText.Size = new System.Drawing.Size(150, 29);
            this.materialCodeText.Style = Sunny.UI.UIStyle.Custom;
            this.materialCodeText.TabIndex = 10;
            this.materialCodeText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialCodeText.Watermark = "";
            // 
            // materialNameText
            // 
            this.materialNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialNameText.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialNameText.Location = new System.Drawing.Point(306, 133);
            this.materialNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialNameText.MinimumSize = new System.Drawing.Size(1, 16);
            this.materialNameText.Name = "materialNameText";
            this.materialNameText.Padding = new System.Windows.Forms.Padding(5);
            this.materialNameText.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialNameText.ShowText = false;
            this.materialNameText.Size = new System.Drawing.Size(150, 29);
            this.materialNameText.Style = Sunny.UI.UIStyle.Custom;
            this.materialNameText.TabIndex = 9;
            this.materialNameText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialNameText.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel2.Location = new System.Drawing.Point(306, 104);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(87, 24);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 13;
            this.uiLabel2.Text = "자재명";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLabel3.Location = new System.Drawing.Point(306, 167);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(87, 24);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 14;
            this.uiLabel3.Text = "자재코드";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaterialCodeListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.materialCodeList);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.materialCodeText);
            this.Controls.Add(this.materialNameText);
            this.Name = "MaterialCodeListView";
            this.Text = "MaterialCodeListView";
            this.Load += new System.EventHandler(this.MaterialCodeListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ListView materialCodeList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Sunny.UI.UIButton deleteButton;
        private Sunny.UI.UIButton insertButton;
        private Sunny.UI.UITextBox materialCodeText;
        private Sunny.UI.UITextBox materialNameText;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
    }
}