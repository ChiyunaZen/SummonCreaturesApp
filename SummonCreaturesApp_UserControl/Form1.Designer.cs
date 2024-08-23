namespace SummonCreaturesApp_UserControl
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
            this.creatureNameTextBox = new System.Windows.Forms.TextBox();
            this.summonButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.actionResultLabel = new System.Windows.Forms.Label();
            this.summonControl = new SummonCreaturesApp_UserControl.SummonControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creatureNameTextBox
            // 
            this.creatureNameTextBox.Location = new System.Drawing.Point(49, 55);
            this.creatureNameTextBox.Name = "creatureNameTextBox";
            this.creatureNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.creatureNameTextBox.TabIndex = 0;
            // 
            // summonButton
            // 
            this.summonButton.Location = new System.Drawing.Point(273, 36);
            this.summonButton.Name = "summonButton";
            this.summonButton.Size = new System.Drawing.Size(125, 59);
            this.summonButton.TabIndex = 1;
            this.summonButton.Text = "召喚";
            this.summonButton.UseVisualStyleBackColor = true;
            this.summonButton.Click += new System.EventHandler(this.summonButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(273, 248);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(125, 59);
            this.attackButton.TabIndex = 2;
            this.attackButton.Text = "攻撃";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // actionResultLabel
            // 
            this.actionResultLabel.AutoSize = true;
            this.actionResultLabel.Location = new System.Drawing.Point(46, 99);
            this.actionResultLabel.Name = "actionResultLabel";
            this.actionResultLabel.Size = new System.Drawing.Size(43, 15);
            this.actionResultLabel.TabIndex = 3;
            this.actionResultLabel.Text = "label1";
            // 
            // summonControl
            // 
            this.summonControl.Location = new System.Drawing.Point(49, 131);
            this.summonControl.Name = "summonControl";
            this.summonControl.Size = new System.Drawing.Size(197, 176);
            this.summonControl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "▼クリーチャーの名前を入力";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summonControl);
            this.Controls.Add(this.actionResultLabel);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.summonButton);
            this.Controls.Add(this.creatureNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creatureNameTextBox;
        private System.Windows.Forms.Button summonButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Label actionResultLabel;
        private SummonControl summonControl;
        private System.Windows.Forms.Label label1;
    }
}

