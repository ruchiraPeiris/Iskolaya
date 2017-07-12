using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Iskolaya
{
    public partial class Attendance : MetroFramework.Forms.MetroForm
    {

        string week;
        int studentId;

        MysqlConn sql = new MysqlConn();

        MySqlCommand command;
        MySqlDataReader mdr;
        public Attendance()
        {

            InitializeComponent();
          
        }

        public void FrmReadBarcode_Load(object sender, EventArgs e)
        {

            this.ActiveControl = txtBarcode;

            if (txtBarcode.Text != null)

                this.ActiveControl = null;

          

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = null;

            this.ActiveControl = txtBarcode;
            lblfirstname.Text = "";
            lblemail.Text = "";
            lbldob.Text = "";
            lblcontact.Text = "";
            lblgender.Text = "";
            lbladdress.Text = "";
            pictureBox1.Image = null;

            pictureBox2.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //}

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        public void setAttendanceMark()






        
        {
            switch (getWeek())
            {
                case 1:
                    checkBox1.Enabled = true; checkBox1.BackColor = System.Drawing.Color.Black; break;

                case 2:
                    checkBox2.Enabled = true; checkBox2.BackColor = System.Drawing.Color.Black; break;
                case 3:
                    checkBox3.Enabled = true; checkBox3.BackColor = System.Drawing.Color.Black; break;

                case 4:
                    checkBox4.Enabled = true; checkBox4.BackColor = System.Drawing.Color.Black; break;
                case 5:
                    checkBox5.Enabled = true; checkBox5.BackColor = System.Drawing.Color.Black; break;





            }
           

        }



        public int getWeek()
        {

            int date = Int32.Parse(DateTime.Now.ToString("dd"));


            int daysinmonth = DateTime.DaysInMonth(Int32.Parse(DateTime.Now.ToString("yyyy")), Int32.Parse(DateTime.Now.ToString("MM")));

            if ((date % 7 == 3 && daysinmonth == 31) || (date % 7 == 1 && daysinmonth == 29) || ((date % 7 < 3) && (daysinmonth > 29)))

                return 5 - ((daysinmonth - date) / 7);


            else

                return 4 - ((daysinmonth - date) / 7);








        }

        private void btnmark_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblfirstname.Text))
                return;
            else if (ValidateChildren(ValidationConstraints.Enabled))
                MessageBox.Show("Data inserted", "Attendance mark message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                return;


            MySqlConnection conDatabase = new MySqlConnection(sql.con);
            conDatabase.Open();
            string query = "INSERT into escolaya_db.attendance(student_id,month,date,week)VALUES('" + studentId + "','" + DateTime.Now.ToString("MM") + "','" + DateTime.Now.ToString("dd-MM-yyyy") + "','" + week + "')";

            command = new MySqlCommand(query, conDatabase);
            command.ExecuteNonQuery();

            conDatabase.Close();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            week = "week1";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            week = "week2";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            week = "week3";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            week = "week4";
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            week = "week5";
        }

        private void txtbox1_validate(object sender, CancelEventArgs e)
        {
            if ((checkBox1.Enabled == true) && (checkBox1.Checked == false))
            {
                e.Cancel = true;
                checkBox1.Focus();
                errorProvider1.SetError(checkBox1, "check this before mark");

            }
        }

        private void checkbox2_validate(object sender, CancelEventArgs e)
        {

            if ((checkBox2.Enabled == true) && (checkBox2.Checked == false))
            {
                e.Cancel = true;
                checkBox2.Focus();
                errorProvider2.SetError(checkBox2, "check this before mark");

            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(checkBox2, null);

            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)



        {
            //try
            //{


            MySqlConnection conDatabase = new MySqlConnection(sql.con);
            conDatabase.Open();
            string query = "SELECT * from escolaya_db.student WHERE barcode='" + txtBarcode.Text + "'";

            command = new MySqlCommand(query, conDatabase);
            mdr = command.ExecuteReader();


            if (mdr.Read())
            {

                lblfirstname.Text = mdr.GetString("full_name");
                lbldob.Text = mdr.GetString("dob");
                lbladdress.Text = mdr.GetString("address");
                lblemail.Text = mdr.GetString("email");
                lblgender.Text = mdr.GetString("gender");
                lblcontact.Text = mdr.GetString("contact_no");
                studentId = mdr.GetInt32("id");


                byte[] img = (byte[])(mdr["image"]);
                if (img == null)
                    pictureBox1.Image = null;
                else
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromStream(new MemoryStream(img));

                }


              
            }
            conDatabase.Close();
            //}
            //catch(Exception ex)
            //{

            setAttendanceMark();
           
        }

        public void fillClass()
        {


            try
            {
                MysqlConn msc = new MysqlConn();
                msc.query = "select class_name from escolaya_db.class  ";

                MySqlConnection conn = new MySqlConnection(msc.con);
                conn.Open();
                msc.command = new MySqlCommand(msc.query, conn);
                msc.mdr = msc.command.ExecuteReader();

                while (msc.mdr.Read())
                {

                    string className = msc.mdr.GetString("class_name");
                    comboclass.Items.Add(className);


                }

                conn.Close();

            }
            catch (Exception ex)
            {


            }


        }


        public void checkClassFeesPaid()
        {

            try
            {
                MysqlConn msc2 = new MysqlConn();
                msc2.query = "select * from escolaya_db.class_fee where month=" + DateTime.Now.ToString("MM")+" and student_id="+studentId;

                MySqlConnection conn = new MySqlConnection(msc2.con);
                conn.Open();
                msc2.command = new MySqlCommand(msc2.query, conn);
                msc2.mdr = msc2.command.ExecuteReader();

                while (msc2.mdr.Read())
                {
                    if (msc2.mdr["id"] != DBNull.Value)
                        return;


                }
                pictureBox2.Visible = true;
            }
            catch (Exception ex)
            {


            }


        }

        private void txtbarcode_leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(lblfirstname.Text))
            checkClassFeesPaid();
        }
    }
}
