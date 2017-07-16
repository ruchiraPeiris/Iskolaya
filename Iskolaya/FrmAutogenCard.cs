using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskolaya
{
    public partial class FrmAutogenCard : MetroFramework.Forms.MetroForm
    {
        string code;
        string name;
        string id;
        public FrmAutogenCard(string code, string name, string id)
        {

            this.code = code;
            this.name = name;
            this.id = id;
            InitializeComponent();
        }

        public void Viewcard(String name, string address, string dob, string picPath)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.ImageLocation = picPath;


            Bitmap bitmap = new Bitmap(code.Length * 40, 80);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Font ofont = new Font("IDAutomationHC39M", 10);

                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, 0, 0,160, 55);
                graphics.DrawString("*" + code + "*", ofont, black, point);


            }

            using (MemoryStream ms = new MemoryStream())
            {

                bitmap.Save(ms, ImageFormat.Png);
                pbbarcode.Image = bitmap;
                pbbarcode.Height = bitmap.Height;
                pbbarcode.Width = bitmap.Width;



            }


            if (!address.Equals(""))
                lblid.Text = address;

            else
                lblid.Text = dob;


            lblstname.Text = name;

        }

        private void FrmAutogenCard_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void btnprint_Click(object sender, EventArgs e)
        {
            int height = panel1.Height;
            bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            panel1.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pbbarcode_Click(object sender, EventArgs e)
        {

        }

        public void getClassDetails() {


            try
            {
                MysqlConn msc = new MysqlConn();
                msc.query = "select institute_name,institute_address from escolaya_db.institute_detail";

                MySqlConnection conn = new MySqlConnection(msc.con);
                conn.Open();
                msc.command = new MySqlCommand(msc.query, conn);
                msc.mdr = msc.command.ExecuteReader();

                while (msc.mdr.Read())
                {

                    lblinstitutename.Text = msc.mdr.GetString("institute_name");
                    lblinstituteaddress.Text = msc.mdr.GetString("institute_address");



                }

                conn.Close();

            }
            catch (Exception ex)
            {


            }


        }
    }
}
