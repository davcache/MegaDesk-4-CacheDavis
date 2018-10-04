namespace MegaDesk_3_CacheDavis
{
    partial class ViewAllQuotes
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
            this.viewBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewBackBtn
            // 
            this.viewBackBtn.Location = new System.Drawing.Point(304, 380);
            this.viewBackBtn.Name = "viewBackBtn";
            this.viewBackBtn.Size = new System.Drawing.Size(115, 37);
            this.viewBackBtn.TabIndex = 0;
            this.viewBackBtn.Text = "Back";
            this.viewBackBtn.UseVisualStyleBackColor = true;
            this.viewBackBtn.Click += new System.EventHandler(this.viewBackBtn_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewBackBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewBackBtn;
    }
}