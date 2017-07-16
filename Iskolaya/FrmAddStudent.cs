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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using Tulpep.NotificationWindow;
using System.IO;

namespace Iskolaya
{
    public partial class FrmAddStudent : MetroFramework.Forms.MetroForm
    {

        string picPath;
        public FrmAddStudent()
        {
            InitializeComponent();


        }

        public void classes()
        {
           
            string[] classType = { "Science","Maths" };
            comboclass.Items.AddRange(classType);

            string[] gradeList = {"A","B","C","S","W" };
            string[] alSubList = {"Com. Maths","Chemistry","Physics","Accounting","Business Studies","Economics","Sinhala","Media","Geogrohpy",};


            comboBox1.Items.AddRange(gradeList);
            comboBox2.Items.AddRange(gradeList);
            comboBox3.Items.AddRange(gradeList);
            comboBox4.Items.AddRange(gradeList);
            comboBox5.Items.AddRange(gradeList);
            comboBox6.Items.AddRange(gradeList);
     
            comboBox16.Items.AddRange(gradeList);
            comboBox17.Items.AddRange(gradeList);
            comboBox18.Items.AddRange(gradeList);

            comboBox13.Items.AddRange(alSubList);
            comboBox14.Items.AddRange(alSubList);
            comboBox15.Items.AddRange(alSubList);


        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        String gender;


        private void metroButton1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int barcode = rnd.Next(100000000,900000000);

            byte[] imageBt = null;
            FileStream fStream = new FileStream(picPath,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            imageBt = br.ReadBytes((int)fStream.Length);


            MysqlConn sql = new MysqlConn();
            string query = "insert into escolaya_db.student(full_name,dob,address,email,gender,nic,contact_no,parent_contact_no,class,added_date,barcode,image) values('" + txtfname.Text + "','"+dateTimePicker1.Value.ToString("dd-MM-yyyy")+"','" + txtaddress.Text + "','" + txtemail.Text + "','" + gender+ "','" + txtnic.Text + "','" + txtcontactno.Text + "','" + txtpcontactno.Text + "','" + comboclass.Text + "','" + DateTime.Now.ToString()+"','"+ barcode.ToString() + "',@IMG)";
            MySqlConnection conDatabase = new MySqlConnection(sql.con);
            MySqlCommand cmdDatabase = new MySqlCommand(query, conDatabase);
            MySqlDataReader myReader;


            //try {

            conDatabase.Open();
            cmdDatabase.Parameters.Add(new MySqlParameter("@IMG", imageBt));
            myReader = cmdDatabase.ExecuteReader();
            

           PopupNotifier popup = new PopupNotifier();
            popup.HeaderColor = Color.DarkSlateGray;
            popup.HeaderHeight = 20;
            popup.TitleText = "Register New Student";
         
            //popup.TitleFont = new Font(FontFamily.GenericSansSerif, 12.0f,FontStyle.Regular);
         
            popup.ContentText = "New user added successfully!!!";
            popup.ContentColor = Color.DarkSlateGray;

            popup.Popup();

            while (myReader.Read())
            {



            }
            FrmAutogenCard card = new FrmAutogenCard(barcode.ToString(), txtfname.Text, barcode.ToString());
            card.Viewcard(txtfname.Text,txtaddress.Text, dateTimePicker1.Value.ToString("dd-MM-yyyy"),picPath);
            card.getClassDetails();
            card.ShowDialog();

            


            //}

            //catch (Exception ex) {




            //}



        }

        private void txtaddress_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All files(*.*)|*.*";
      

            if (ofd.ShowDialog() == DialogResult.OK) {
                 picPath = ofd.FileName.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = picPath;


            }
        }
    }
}
