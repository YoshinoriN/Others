namespace StateAndFactory
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.button_Normal = new System.Windows.Forms.Button();
            this.button_Warning = new System.Windows.Forms.Button();
            this.button_Error = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Normal
            // 
            this.button_Normal.Location = new System.Drawing.Point(17, 54);
            this.button_Normal.Name = "button_Normal";
            this.button_Normal.Size = new System.Drawing.Size(94, 24);
            this.button_Normal.TabIndex = 0;
            this.button_Normal.Text = "Normal";
            this.button_Normal.UseVisualStyleBackColor = true;
            this.button_Normal.Click += new System.EventHandler(this.button_Normal_Click);
            // 
            // button_Warning
            // 
            this.button_Warning.Location = new System.Drawing.Point(117, 54);
            this.button_Warning.Name = "button_Warning";
            this.button_Warning.Size = new System.Drawing.Size(94, 24);
            this.button_Warning.TabIndex = 1;
            this.button_Warning.Text = "Warning";
            this.button_Warning.UseVisualStyleBackColor = true;
            this.button_Warning.Click += new System.EventHandler(this.button_Warning_Click);
            // 
            // button_Error
            // 
            this.button_Error.Location = new System.Drawing.Point(216, 54);
            this.button_Error.Name = "button_Error";
            this.button_Error.Size = new System.Drawing.Size(94, 24);
            this.button_Error.TabIndex = 2;
            this.button_Error.Text = "Error";
            this.button_Error.UseVisualStyleBackColor = true;
            this.button_Error.Click += new System.EventHandler(this.button_Error_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(17, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(293, 19);
            this.textBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 91);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_Error);
            this.Controls.Add(this.button_Warning);
            this.Controls.Add(this.button_Normal);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Normal;
        private System.Windows.Forms.Button button_Warning;
        private System.Windows.Forms.Button button_Error;
        private System.Windows.Forms.TextBox textBox;
    }
}

