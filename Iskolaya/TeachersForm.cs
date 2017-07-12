
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskolaya
{
    public partial class TeachersForm : MetroForm
    {
        public TeachersForm()
        {
            InitializeComponent();
            diplaySubject();
        }

        void diplaySubject()
        {
            
            string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
            string query = "select * from subject";
            MySqlConnection conn = new MySqlConnection(conStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            

            subCombo.ValueMember = "id";

            subCombo.DisplayMember = "name";
            subCombo.DataSource = dt;

            conn.Close();
        }

        private void subjectBtn_Click(object sender, EventArgs e)
        {
            SubjectForm s = new SubjectForm();
            s.Show();
        }

        private void subCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Text = "";
            addressTxt.Text = "";
            emailTxt.Text = "";
            mobileTxt.Text = "";
            detailsTxt.Text = "";
            maleRBtn.Checked = false;
            femaleRBtn.Checked = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            int id = (int)subCombo.SelectedValue;
            DateTime d = DateTime.Parse(dob.Text);
            string bDate = d.ToString("yyyy-MM-dd");
            string email = emailTxt.Text;

            //metroTextBox1.Text=(dob.Value);
            if (nameTxt.Text == null || addressTxt.Text == null || emailTxt.Text == null || mobileTxt.Text == null ||(!maleRBtn.Checked && !femaleRBtn.Checked))
                {
                    MessageBox.Show("One of the field is empty... check....");
                }
                else {
                    //int id;
                    string gender;
                    if (maleRBtn.Checked)
                    {
                        gender = "male";
                    }
                    else
                    {
                        gender = "female";
                    }
                    
                    string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                    string query = "insert into teacher(full_name,subject_id,address,email_address,mobile_number,sex,other_details,create_date,last_update,dob) values('" + nameTxt.Text + "'," + id + ",'" + addressTxt.Text + "','" + emailTxt.Text + "','" + mobileTxt.Text + "','" + gender + "','"+detailsTxt.Text+"',NOW(),NOW(),'"+bDate+"')";
                    MySqlConnection conn = new MySqlConnection(conStr);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher added successfully ...");
                    conn.Close();
                }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "delete from teacher where full_name='" + nameTxt.Text + "'";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher deleted successfully ...");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "select s.name,t.address,t.email_address,t.mobile_number,t.sex,t.other_details,t.dob from teacher t,subject s where full_name='" + nameTxt.Text + "' and s.id=t.subject_id";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                var r = adapter.Fill(dt);
                addressTxt.Text = dt.Rows[0][1].ToString();
                emailTxt.Text = dt.Rows[0][2].ToString();
                mobileTxt.Text = dt.Rows[0][3].ToString();
                detailsTxt.Text= dt.Rows[0][5].ToString();
                subCombo.Text = dt.Rows[0][0].ToString();
                dob.Text = DateTime.Parse(dt.Rows[0][6].ToString()).ToString();

                if (dt.Rows[0][4].ToString() == "male")
                {
                    maleRBtn.Select();
                }
                else if (dt.Rows[0][4].ToString() == "female")
                {
                    femaleRBtn.Select();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id= (int)subCombo.SelectedValue;
                DateTime d = DateTime.Parse(dob.Text);
                string bDate = d.ToString("yyyy-MM-dd");
                string email = emailTxt.Text;
                string gender;
                if (maleRBtn.Checked)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "update teacher set subject_id=" + id + ",sex='" + gender + "',email_address='"+emailTxt.Text+ "',address='" + addressTxt.Text + "',dob='"+bDate+"',other_details='"+detailsTxt.Text+"',last_update=NOW() where full_name='" + nameTxt.Text + "'";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher updated successfully ...");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void classBtn_Click(object sender, EventArgs e)
        {
            ClassForm c = new ClassForm();
            c.Show();
        }
    }
}
