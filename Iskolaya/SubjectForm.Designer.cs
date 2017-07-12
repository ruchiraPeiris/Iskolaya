namespace Iskolaya
{
    partial class SubjectForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.subNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.gradeTxt = new MetroFramework.Controls.MetroTextBox();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.delBtn = new MetroFramework.Controls.MetroButton();
            this.updateBtn = new MetroFramework.Controls.MetroButton();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Subject Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Grade";
            // 
            // subNameTxt
            // 
            // 
            // 
            // 
            this.subNameTxt.CustomButton.Image = null;
            this.subNameTxt.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.subNameTxt.CustomButton.Name = "";
            this.subNameTxt.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.subNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subNameTxt.CustomButton.TabIndex = 1;
            this.subNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subNameTxt.CustomButton.UseSelectable = true;
            this.subNameTxt.CustomButton.Visible = false;
            this.subNameTxt.Lines = new string[0];
            this.subNameTxt.Location = new System.Drawing.Point(172, 75);
            this.subNameTxt.MaxLength = 32767;
            this.subNameTxt.Name = "subNameTxt";
            this.subNameTxt.PasswordChar = '\0';
            this.subNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subNameTxt.SelectedText = "";
            this.subNameTxt.SelectionLength = 0;
            this.subNameTxt.SelectionStart = 0;
            this.subNameTxt.ShortcutsEnabled = true;
            this.subNameTxt.Size = new System.Drawing.Size(177, 20);
            this.subNameTxt.TabIndex = 2;
            this.subNameTxt.UseSelectable = true;
            this.subNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gradeTxt
            // 
            // 
            // 
            // 
            this.gradeTxt.CustomButton.Image = null;
            this.gradeTxt.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.gradeTxt.CustomButton.Name = "";
            this.gradeTxt.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.gradeTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gradeTxt.CustomButton.TabIndex = 1;
            this.gradeTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gradeTxt.CustomButton.UseSelectable = true;
            this.gradeTxt.CustomButton.Visible = false;
            this.gradeTxt.Lines = new string[0];
            this.gradeTxt.Location = new System.Drawing.Point(172, 113);
            this.gradeTxt.MaxLength = 32767;
            this.gradeTxt.Name = "gradeTxt";
            this.gradeTxt.PasswordChar = '\0';
            this.gradeTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gradeTxt.SelectedText = "";
            this.gradeTxt.SelectionLength = 0;
            this.gradeTxt.SelectionStart = 0;
            this.gradeTxt.ShortcutsEnabled = true;
            this.gradeTxt.Size = new System.Drawing.Size(177, 20);
            this.gradeTxt.TabIndex = 3;
            this.gradeTxt.UseSelectable = true;
            this.gradeTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gradeTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(429, 77);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(172, 186);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(429, 186);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 6;
            this.delBtn.Text = "Delete";
            this.delBtn.UseSelectable = true;
            this.delBtn.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(305, 186);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseSelectable = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(429, 113);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 246);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.gradeTxt);
            this.Controls.Add(this.subNameTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SubjectForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox subNameTxt;
        private MetroFramework.Controls.MetroTextBox gradeTxt;
        private MetroFramework.Controls.MetroButton clearBtn;
        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroButton delBtn;
        private MetroFramework.Controls.MetroButton updateBtn;
        private MetroFramework.Controls.MetroButton backBtn;
    }
}