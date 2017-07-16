namespace Iskolaya
{
    partial class FrmAutogenCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutogenCard));
            this.pbbarcode = new System.Windows.Forms.PictureBox();
            this.lblinstitutename = new System.Windows.Forms.Label();
            this.btnprint = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.lblstname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblinstituteaddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbbarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbbarcode
            // 
            this.pbbarcode.BackColor = System.Drawing.Color.RosyBrown;
            this.pbbarcode.Location = new System.Drawing.Point(29, 149);
            this.pbbarcode.Name = "pbbarcode";
            this.pbbarcode.Size = new System.Drawing.Size(151, 48);
            this.pbbarcode.TabIndex = 0;
            this.pbbarcode.TabStop = false;
            this.pbbarcode.Click += new System.EventHandler(this.pbbarcode_Click);
            // 
            // lblinstitutename
            // 
            this.lblinstitutename.AutoSize = true;
            this.lblinstitutename.BackColor = System.Drawing.Color.Black;
            this.lblinstitutename.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstitutename.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblinstitutename.Location = new System.Drawing.Point(7, 13);
            this.lblinstitutename.Name = "lblinstitutename";
            this.lblinstitutename.Size = new System.Drawing.Size(172, 25);
            this.lblinstitutename.TabIndex = 1;
            this.lblinstitutename.Text = "Institute Name";
            // 
            // btnprint
            // 
            this.btnprint.ActiveControl = null;
            this.btnprint.Location = new System.Drawing.Point(523, 359);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(71, 40);
            this.btnprint.TabIndex = 2;
            this.btnprint.Text = "Print";
            this.btnprint.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnprint.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnprint.UseSelectable = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 88);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.lblstname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbbarcode);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(120, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 211);
            this.panel1.TabIndex = 8;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblid.Location = new System.Drawing.Point(104, 115);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(56, 19);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "label2";
            // 
            // lblstname
            // 
            this.lblstname.AutoSize = true;
            this.lblstname.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstname.Location = new System.Drawing.Point(103, 79);
            this.lblstname.Name = "lblstname";
            this.lblstname.Size = new System.Drawing.Size(77, 25);
            this.lblstname.TabIndex = 8;
            this.lblstname.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblinstituteaddress);
            this.panel2.Controls.Add(this.lblinstitutename);
            this.panel2.Location = new System.Drawing.Point(91, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 70);
            this.panel2.TabIndex = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.printPreviewDialog1_FormClosed);
            // 
            // lblinstituteaddress
            // 
            this.lblinstituteaddress.AutoSize = true;
            this.lblinstituteaddress.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstituteaddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblinstituteaddress.Location = new System.Drawing.Point(13, 43);
            this.lblinstituteaddress.Name = "lblinstituteaddress";
            this.lblinstituteaddress.Size = new System.Drawing.Size(40, 15);
            this.lblinstituteaddress.TabIndex = 2;
            this.lblinstituteaddress.Text = "label2";
            // 
            // FrmAutogenCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 455);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 5000);
            this.Name = "FrmAutogenCard";
            this.Load += new System.EventHandler(this.FrmAutogenCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbbarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbbarcode;
        private System.Windows.Forms.Label lblinstitutename;
        private MetroFramework.Controls.MetroTile btnprint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblstname;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblinstituteaddress;
    }
}