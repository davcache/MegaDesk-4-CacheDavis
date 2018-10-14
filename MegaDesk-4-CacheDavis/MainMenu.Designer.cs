namespace MegaDesk_4_CacheDavis
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddQuotebtn = new System.Windows.Forms.Button();
            this.viewQuotebtn = new System.Windows.Forms.Button();
            this.searchQuotebtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuotebtn
            // 
            this.AddQuotebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuotebtn.Location = new System.Drawing.Point(49, 47);
            this.AddQuotebtn.Name = "AddQuotebtn";
            this.AddQuotebtn.Size = new System.Drawing.Size(136, 38);
            this.AddQuotebtn.TabIndex = 0;
            this.AddQuotebtn.Text = "Add New Quote";
            this.AddQuotebtn.UseVisualStyleBackColor = true;
            this.AddQuotebtn.Click += new System.EventHandler(this.AddQuotebtn_Click);
            // 
            // viewQuotebtn
            // 
            this.viewQuotebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotebtn.Location = new System.Drawing.Point(231, 47);
            this.viewQuotebtn.Name = "viewQuotebtn";
            this.viewQuotebtn.Size = new System.Drawing.Size(136, 38);
            this.viewQuotebtn.TabIndex = 1;
            this.viewQuotebtn.Text = "View Quotes";
            this.viewQuotebtn.UseVisualStyleBackColor = true;
            this.viewQuotebtn.Click += new System.EventHandler(this.viewQuotebtn_Click);
            // 
            // searchQuotebtn
            // 
            this.searchQuotebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotebtn.Location = new System.Drawing.Point(408, 47);
            this.searchQuotebtn.Name = "searchQuotebtn";
            this.searchQuotebtn.Size = new System.Drawing.Size(136, 38);
            this.searchQuotebtn.TabIndex = 2;
            this.searchQuotebtn.Text = "Search Quotes";
            this.searchQuotebtn.UseVisualStyleBackColor = true;
            this.searchQuotebtn.Click += new System.EventHandler(this.searchQuotebtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(585, 47);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(136, 38);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 269);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuotebtn);
            this.Controls.Add(this.viewQuotebtn);
            this.Controls.Add(this.AddQuotebtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MegaDesk Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuotebtn;
        private System.Windows.Forms.Button viewQuotebtn;
        private System.Windows.Forms.Button searchQuotebtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

