namespace MegaDesk_4_CacheDavis
{
    partial class AddQuote
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
            this.backBtn = new System.Windows.Forms.Button();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.cusNameLbl = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.numericUpDownDrawer = new System.Windows.Forms.NumericUpDown();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.comMaterial = new System.Windows.Forms.ComboBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.comboBoxShipping = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawer)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(304, 381);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(115, 37);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(252, 57);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(213, 26);
            this.txtCusName.TabIndex = 1;
            // 
            // cusNameLbl
            // 
            this.cusNameLbl.AutoSize = true;
            this.cusNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameLbl.Location = new System.Drawing.Point(122, 57);
            this.cusNameLbl.Name = "cusNameLbl";
            this.cusNameLbl.Size = new System.Drawing.Size(124, 20);
            this.cusNameLbl.TabIndex = 2;
            this.cusNameLbl.Text = "Customer Name";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(71, 152);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(48, 17);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width:";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWidth.Location = new System.Drawing.Point(126, 150);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownWidth.TabIndex = 4;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(71, 219);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(50, 17);
            this.lblDepth.TabIndex = 5;
            this.lblDepth.Text = "Depth:";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDepth.Location = new System.Drawing.Point(126, 217);
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDepth.TabIndex = 6;
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawers.Location = new System.Drawing.Point(461, 152);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(134, 17);
            this.lblDrawers.TabIndex = 7;
            this.lblDrawers.Text = "Number of Drawers:";
            // 
            // numericUpDownDrawer
            // 
            this.numericUpDownDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDrawer.Location = new System.Drawing.Point(601, 150);
            this.numericUpDownDrawer.Name = "numericUpDownDrawer";
            this.numericUpDownDrawer.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDrawer.TabIndex = 8;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(460, 217);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(62, 17);
            this.lblMaterial.TabIndex = 9;
            this.lblMaterial.Text = "Material:";
            // 
            // comMaterial
            // 
            this.comMaterial.FormattingEnabled = true;
            this.comMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.comMaterial.Location = new System.Drawing.Point(528, 218);
            this.comMaterial.Name = "comMaterial";
            this.comMaterial.Size = new System.Drawing.Size(121, 21);
            this.comMaterial.TabIndex = 10;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.Location = new System.Drawing.Point(308, 279);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(67, 17);
            this.lblShipping.TabIndex = 11;
            this.lblShipping.Text = "Shipping:";
            // 
            // comboBoxShipping
            // 
            this.comboBoxShipping.FormattingEnabled = true;
            this.comboBoxShipping.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day"});
            this.comboBoxShipping.Location = new System.Drawing.Point(387, 278);
            this.comboBoxShipping.Name = "comboBoxShipping";
            this.comboBoxShipping.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShipping.TabIndex = 12;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxShipping);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.comMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.numericUpDownDrawer);
            this.Controls.Add(this.lblDrawers);
            this.Controls.Add(this.numericUpDownDepth);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cusNameLbl);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.backBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label cusNameLbl;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.NumericUpDown numericUpDownDrawer;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox comMaterial;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.ComboBox comboBoxShipping;
    }
}