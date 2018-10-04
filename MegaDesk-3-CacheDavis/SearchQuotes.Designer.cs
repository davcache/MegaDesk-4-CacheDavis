namespace MegaDesk_3_CacheDavis
{
    partial class SearchQuotes
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
            this.searchBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBackBtn
            // 
            this.searchBackBtn.Location = new System.Drawing.Point(318, 382);
            this.searchBackBtn.Name = "searchBackBtn";
            this.searchBackBtn.Size = new System.Drawing.Size(115, 37);
            this.searchBackBtn.TabIndex = 0;
            this.searchBackBtn.Text = "Back";
            this.searchBackBtn.UseVisualStyleBackColor = true;
            this.searchBackBtn.Click += new System.EventHandler(this.searchBackBtn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBackBtn);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchBackBtn;
    }
}