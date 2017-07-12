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
    public partial class ClassForm : MetroForm
    {
        public ClassForm()
        {
            InitializeComponent();
            diplaySubject();
            diplayTeacher();
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
        void diplayTeacher()
        {

            string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
            string query = "select * from teacher";
            MySqlConnection conn = new MySqlConnection(conStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            tecCombo.ValueMember = "id";

            tecCombo.DisplayMember = "full_name";
            tecCombo.DataSource = dt;

            conn.Close();
        }
        private void metroLabel3_Click(object sender, EventArgs e)
        {


        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            

        }

        private void dayCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == null || subCombo.Text==null || tecCombo.Text==null || timeCombo.Text==null || dayCombo.Text==null || placeCombo.Text==null)
            {
                MessageBox.Show("One of the field is empty... check....");
            }
            else {
                //int id;
               

                string conStr = "server=127.0.0.1;database=escolaya_db;user id=root;password=lahk;";
                string query = "insert into class(teacher_id,subject_id,timeSlot,HallNo,class_name) values(" + nameTxt.Text + "," + tecCombo.Text + "," + subCombo.Text + ",'" + timeCombo.Text + "','" + placeCombo.Text + "','"+ nameTxt.Text + "')";
                MySqlConnection conn = new MySqlConnection(conStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("class added successfully ...");
                conn.Close();
            }

        }
    }
}
