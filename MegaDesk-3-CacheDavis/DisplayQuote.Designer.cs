namespace MegaDesk_3_CacheDavis
{
    partial class DisplayQuote
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
            this.displayBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayBackBtn
            // 
            this.displayBackBtn.Location = new System.Drawing.Point(314, 384);
            this.displayBackBtn.Name = "displayBackBtn";
            this.displayBackBtn.Size = new System.Drawing.Size(115, 37);
            this.displayBackBtn.TabIndex = 0;
            this.displayBackBtn.Text = "Back";
            this.displayBackBtn.UseVisualStyleBackColor = true;
            this.displayBackBtn.Click += new System.EventHandler(this.displayBackBtn_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayBackBtn);
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayBackBtn;
    }
}