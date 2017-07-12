namespace Iskolaya
{
    partial class ClassForm
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.classDay = new MetroFramework.Controls.MetroLabel();
            this.dayCombo = new MetroFramework.Controls.MetroComboBox();
            this.timeCombo = new MetroFramework.Controls.MetroComboBox();
            this.tecCombo = new MetroFramework.Controls.MetroComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.subCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.placeCombo = new MetroFramework.Controls.MetroComboBox();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.nameTxt = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Teacher";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Subject";
            // 
            // classDay
            // 
            this.classDay.AutoSize = true;
            this.classDay.Location = new System.Drawing.Point(20, 200);
            this.classDay.Name = "classDay";
            this.classDay.Size = new System.Drawing.Size(64, 19);
            this.classDay.TabIndex = 6;
            this.classDay.Text = "Class Day";
            this.classDay.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // dayCombo
            // 
            this.dayCombo.FormattingEnabled = true;
            this.dayCombo.ItemHeight = 23;
            this.dayCombo.Items.AddRange(new object[] {
            "MONDAY",
            "TEUSDAY",
            "WEDNESDAY",
            "THURDAY",
            "FRIDAY",
            "SATURDAY",
            "SUNDAY"});
            this.dayCombo.Location = new System.Drawing.Point(142, 200);
            this.dayCombo.Name = "dayCombo";
            this.dayCombo.Size = new System.Drawing.Size(121, 29);
            this.dayCombo.TabIndex = 7;
            this.dayCombo.UseSelectable = true;
            this.dayCombo.SelectedIndexChanged += new System.EventHandler(this.dayCombo_SelectedIndexChanged);
            // 
            // timeCombo
            // 
            this.timeCombo.FormattingEnabled = true;
            this.timeCombo.ItemHeight = 23;
            this.timeCombo.Items.AddRange(new object[] {
            "8.00-100AM",
            "10.00-12.00AM"});
            this.timeCombo.Location = new System.Drawing.Point(142, 247);
            this.timeCombo.Name = "timeCombo";
            this.timeCombo.Size = new System.Drawing.Size(121, 29);
            this.timeCombo.TabIndex = 8;
            this.timeCombo.Tag = "Time Slot";
            this.timeCombo.UseSelectable = true;
            // 
            // tecCombo
            // 
            this.tecCombo.FormattingEnabled = true;
            this.tecCombo.ItemHeight = 23;
            this.tecCombo.Location = new System.Drawing.Point(142, 122);
            this.tecCombo.Name = "tecCombo";
            this.tecCombo.Size = new System.Drawing.Size(121, 29);
            this.tecCombo.TabIndex = 9;
            this.tecCombo.UseSelectable = true;
            // 
            // subCombo
            // 
            this.subCombo.FormattingEnabled = true;
            this.subCombo.ItemHeight = 23;
            this.subCombo.Location = new System.Drawing.Point(142, 161);
            this.subCombo.Name = "subCombo";
            this.subCombo.Size = new System.Drawing.Size(121, 29);
            this.subCombo.TabIndex = 10;
            this.subCombo.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 247);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Time Slot";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 293);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Holl No";
            // 
            // placeCombo
            // 
            this.placeCombo.FormattingEnabled = true;
            this.placeCombo.ItemHeight = 23;
            this.placeCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.placeCombo.Location = new System.Drawing.Point(142, 293);
            this.placeCombo.Name = "placeCombo";
            this.placeCombo.Size = new System.Drawing.Size(121, 29);
            this.placeCombo.TabIndex = 13;
            this.placeCombo.UseSelectable = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(367, 82);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(367, 128);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(367, 173);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 16;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(367, 216);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 17;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(367, 266);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.TabIndex = 18;
            this.metroButton5.Text = "metroButton5";
            this.metroButton5.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 82);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Class Name";
            // 
            // nameTxt
            // 
            // 
            // 
            // 
            this.nameTxt.CustomButton.Image = null;
            this.nameTxt.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.nameTxt.CustomButton.Name = "";
            this.nameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTxt.CustomButton.TabIndex = 1;
            this.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTxt.CustomButton.UseSelectable = true;
            this.nameTxt.CustomButton.Visible = false;
            this.nameTxt.Lines = new string[0];
            this.nameTxt.Location = new System.Drawing.Point(142, 82);
            this.nameTxt.MaxLength = 32767;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionLength = 0;
            this.nameTxt.SelectionStart = 0;
            this.nameTxt.ShortcutsEnabled = true;
            this.nameTxt.Size = new System.Drawing.Size(121, 23);
            this.nameTxt.TabIndex = 20;
            this.nameTxt.UseSelectable = true;
            this.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 497);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.placeCombo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.subCombo);
            this.Controls.Add(this.tecCombo);
            this.Controls.Add(this.timeCombo);
            this.Controls.Add(this.dayCombo);
            this.Controls.Add(this.classDay);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel classDay;
        private MetroFramework.Controls.MetroComboBox dayCombo;
        private MetroFramework.Controls.MetroComboBox timeCombo;
        private MetroFramework.Controls.MetroComboBox tecCombo;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.BindingSource subjectBindingSource2;
        private System.Windows.Forms.BindingSource subjectBindingSource3;
        private MetroFramework.Controls.MetroComboBox subCombo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox placeCombo;
        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox nameTxt;
       
    }
}