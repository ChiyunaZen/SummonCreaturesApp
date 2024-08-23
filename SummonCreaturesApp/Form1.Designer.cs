namespace SummonCreaturesApp
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.creatureNameLabel = new System.Windows.Forms.Label();
            this.creatureNameTextBox = new System.Windows.Forms.TextBox();
            this.summonButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.creatureListBox = new System.Windows.Forms.ListBox();
            this.actionResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creatureNameLabel
            // 
            this.creatureNameLabel.AutoSize = true;
            this.creatureNameLabel.Location = new System.Drawing.Point(91, 73);
            this.creatureNameLabel.Name = "creatureNameLabel";
            this.creatureNameLabel.Size = new System.Drawing.Size(114, 15);
            this.creatureNameLabel.TabIndex = 0;
            this.creatureNameLabel.Text = "クリーチャーの名前";
            // 
            // creatureNameTextBox
            // 
            this.creatureNameTextBox.Location = new System.Drawing.Point(94, 205);
            this.creatureNameTextBox.Name = "creatureNameTextBox";
            this.creatureNameTextBox.Size = new System.Drawing.Size(152, 22);
            this.creatureNameTextBox.TabIndex = 1;
            this.creatureNameTextBox.Text = "クリーチャーの名前を入力";
            // 
            // summonButton
            // 
            this.summonButton.Location = new System.Drawing.Point(323, 73);
            this.summonButton.Name = "summonButton";
            this.summonButton.Size = new System.Drawing.Size(102, 72);
            this.summonButton.TabIndex = 2;
            this.summonButton.Text = "召喚ボタン";
            this.summonButton.UseVisualStyleBackColor = true;
            this.summonButton.Click += new System.EventHandler(this.summonButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(323, 183);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(102, 67);
            this.attackButton.TabIndex = 3;
            this.attackButton.Text = "攻撃ボタン";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // creatureListBox
            // 
            this.creatureListBox.FormattingEnabled = true;
            this.creatureListBox.ItemHeight = 15;
            this.creatureListBox.Location = new System.Drawing.Point(532, 73);
            this.creatureListBox.Name = "creatureListBox";
            this.creatureListBox.Size = new System.Drawing.Size(139, 109);
            this.creatureListBox.TabIndex = 4;
            // 
            // actionResultLabel
            // 
            this.actionResultLabel.AutoSize = true;
            this.actionResultLabel.Location = new System.Drawing.Point(553, 235);
            this.actionResultLabel.Name = "actionResultLabel";
            this.actionResultLabel.Size = new System.Drawing.Size(101, 15);
            this.actionResultLabel.TabIndex = 5;
            this.actionResultLabel.Text = "アクションの結果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.actionResultLabel);
            this.Controls.Add(this.creatureListBox);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.summonButton);
            this.Controls.Add(this.creatureNameTextBox);
            this.Controls.Add(this.creatureNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creatureNameLabel;
        private System.Windows.Forms.TextBox creatureNameTextBox;
        private System.Windows.Forms.Button summonButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.ListBox creatureListBox;
        private System.Windows.Forms.Label actionResultLabel;
    }
}

