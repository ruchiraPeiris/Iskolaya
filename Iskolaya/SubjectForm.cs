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
    public partial class SubjectForm : MetroForm
    {
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "delete from subject where name='" + subNameTxt.Text + "'";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject deleted successfully ...");
                conn.Close();
            }
            catch
            {

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            subNameTxt.Text = "";
            gradeTxt.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "insert into subject(name,create_date,last_update,grade) values('" + subNameTxt.Text + "',NOW(),NOW(),'" + gradeTxt.Text + "')";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject added successfully ...");
                conn.Close();
            }
            catch
            {

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "update subject set grade='" + gradeTxt.Text + "',last_update=NOW() where name='" + subNameTxt.Text + "'";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject updated successfully ...");
                conn.Close();
            }
            catch
            {

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersForm t = new TeachersForm();
            t.Show();
        }
    }
}
