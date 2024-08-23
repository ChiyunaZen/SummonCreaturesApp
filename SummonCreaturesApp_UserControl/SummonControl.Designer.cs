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
            this.SuspendLayout();
            // 
            // creatureListBox
            // 
            this.creatureListBox.FormattingEnabled = true;
            this.creatureListBox.ItemHeight = 15;
            this.creatureListBox.Location = new System.Drawing.Point(13, 29);
            this.creatureListBox.Name = "creatureListBox";
            this.creatureListBox.Size = new System.Drawing.Size(120, 94);
            this.creatureListBox.TabIndex = 0;
            // 
            // SummonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.creatureListBox);
            this.Name = "SummonControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox creatureListBox;
    }
}
