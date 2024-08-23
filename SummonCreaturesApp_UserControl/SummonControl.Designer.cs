namespace SummonCreaturesApp_UserControl
{
    partial class SummonControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.creatureListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creatureListBox
            // 
            this.creatureListBox.FormattingEnabled = true;
            this.creatureListBox.ItemHeight = 15;
            this.creatureListBox.Location = new System.Drawing.Point(0, 4);
            this.creatureListBox.Name = "creatureListBox";
            this.creatureListBox.Size = new System.Drawing.Size(196, 154);
            this.creatureListBox.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(3, 164);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(81, 32);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "削除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(90, 164);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(81, 32);
            this.renameButton.TabIndex = 2;
            this.renameButton.Text = "変更";
            this.renameButton.UseVisualStyleBackColor = true;
            // 
            // SummonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.creatureListBox);
            this.Name = "SummonControl";
            this.Size = new System.Drawing.Size(196, 281);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox creatureListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button renameButton;
    }
}
