namespace Iskolaya
{
    partial class Ucdashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtattendance = new MetroFramework.Controls.MetroTile();
            this.mtstdntdetail = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtattendance
            // 
            this.mtattendance.ActiveControl = null;
            this.mtattendance.Location = new System.Drawing.Point(69, 97);
            this.mtattendance.Name = "mtattendance";
            this.mtattendance.Size = new System.Drawing.Size(177, 115);
            this.mtattendance.TabIndex = 0;
            this.mtattendance.Text = "Attendance";
            this.mtattendance.UseSelectable = true;
            // 
            // mtstdntdetail
            // 
            this.mtstdntdetail.ActiveControl = null;
            this.mtstdntdetail.Location = new System.Drawing.Point(278, 97);
            this.mtstdntdetail.Name = "mtstdntdetail";
            this.mtstdntdetail.Size = new System.Drawing.Size(164, 115);
            this.mtstdntdetail.TabIndex = 1;
            this.mtstdntdetail.Text = "Student Details";
            this.mtstdntdetail.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(69, 247);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(361, 153);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Register New Student";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(471, 97);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(215, 172);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Teacher Bill";
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(471, 287);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(215, 113);
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "metroTile5";
            this.metroTile5.UseSelectable = true;
            // 
            // Ucdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.mtstdntdetail);
            this.Controls.Add(this.mtattendance);
            this.Name = "Ucdashboard";
            this.Size = new System.Drawing.Size(759, 433);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtattendance;
        private MetroFramework.Controls.MetroTile mtstdntdetail;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
    }
}
