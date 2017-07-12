namespace Iskolaya
{
    partial class FrmClassFees
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btnpay = new MetroFramework.Controls.MetroTile();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(149, 98);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(168, 20);
            this.txtbarcode.TabIndex = 4;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            this.txtbarcode.Leave += new System.EventHandler(this.txtbarcode_leave);
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(149, 184);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(168, 20);
            this.txtamount.TabIndex = 6;
            // 
            // btnpay
            // 
            this.btnpay.ActiveControl = null;
            this.btnpay.Location = new System.Drawing.Point(271, 226);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(88, 51);
            this.btnpay.TabIndex = 7;
            this.btnpay.Text = "Pay";
            this.btnpay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnpay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnpay.UseSelectable = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(297, 46);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmClassFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmClassFees";
            this.Text = "FrmClassFees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtamount;
        private MetroFramework.Controls.MetroTile btnpay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button button1;
    }
}