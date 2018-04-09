namespace CH1102B
{
    partial class Form1
    {
        /// <summary>
        /// 设计工具所需的变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的资源。
        /// </summary>
        /// <param name="disposing">如果应该处置 Managed 资源则为 true，否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计工具产生的程序代码

        /// <summary>
        /// 此为设计工具支持所需的方法——请勿使用程序代码编辑器
        /// 修改这个方法的内容。
        /// </summary>
      private void InitializeComponent()
      {
            this.displayRTF = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayRTF
            // 
            this.displayRTF.Location = new System.Drawing.Point(34, 22);
            this.displayRTF.Name = "displayRTF";
            this.displayRTF.Size = new System.Drawing.Size(373, 169);
            this.displayRTF.TabIndex = 0;
            this.displayRTF.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(150, 209);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 35);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开文件";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 269);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.displayRTF);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CH1102B";
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.RichTextBox displayRTF;
      private System.Windows.Forms.Button btnOpen;

   }
}

