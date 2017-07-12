using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskolaya
{
    public partial class UserForm : MetroForm
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void userRegBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userNameText.Text == null || addressText.Text == null || emailText.Text == null || contactText.Text == null || pwdText.Text == null || (!checkBox1.Checked || !checkBox2.Checked) || (!adminRBtn.Checked || !userRBtn.Checked))
                {
                    MessageBox.Show("One of the field is empty... check....");
                }
                else {
                    int id;
                    string gender;
                    if (adminRBtn.Checked)
                    {
                        id = 1;
                    }
                    else
                    {
                        id = 2;
                    }
                    if (checkBox1.Checked)
                    {
                        gender = "male";
                    }
                    else
                    {
                        gender = "female";
                    }
                    string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                    string query = "insert into system_user(user_type_id,user_name,password,email,address,last_update,contactNo,gender) values(" + id + ",'" + userNameText.Text + "','" + pwdText.Text + "','" + emailText.Text + "','" + addressText.Text + "',NOW(),'" + contactText.Text + "','" + gender + "')";
                    MySqlConnection conn = new MySqlConnection(conStr);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully ...");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "select user_name,password,email,address,contactNo,gender,user_type_id from system_user where user_name='" + userNameText.Text + "'";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                var r = adapter.Fill(dt);
                addressText.Text = dt.Rows[0][3].ToString();
                emailText.Text = dt.Rows[0][2].ToString();
                contactText.Text = dt.Rows[0][4].ToString();
                if (int.Parse(dt.Rows[0][6].ToString()) == 1)
                {
                    adminRBtn.Select();
                }
                else if (int.Parse(dt.Rows[0][6].ToString()) == 2)
                {
                    userRBtn.Select();
                }

                if (dt.Rows[0][5].ToString() == "male")
                {
                    checkBox1.Select();
                }
                else if (dt.Rows[0][5].ToString() == "female")
                {
                    checkBox2.Select();
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
                int id;
                string gender;
                if (adminRBtn.Checked)
                {
                    id = 1;
                }
                else
                {
                    id = 2;
                }
                if (checkBox1.Checked)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "update system_user set user_type_id=" + id + ",gender='" + gender + "',last_update=NOW() where user_name='" + userNameText.Text + "'";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated successfully ...");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "delete from system_user where user_name='" + userNameText.Text + "'";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully ...");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                userNameText.Text = "";
                addressText.Text = "";
                pwdText.Text = "";
                contactText.Text = "";
                emailText.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                adminRBtn.Checked = false;
                userRBtn.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
