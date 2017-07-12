using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskolaya
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //try
            //{
            lbldate.Text = DateTime.Now.ToLongDateString();
            imgpropic.Image = Image.FromFile(@"C:\Users\ruchiraPc\Documents\Visual Studio 2015\Projects\Iskolaya\Iskolaya\pro_pic\dollar_bill.jpg");
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(imgpropic.DisplayRectangle);
            imgpropic.Region = new Region(gp);

            //}

            //catch(Exception ex) {

            //    Console.Write(ex);






            //}
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            FrmAddStudent frm = new FrmAddStudent();

            frm.classes();

            frm.ShowDialog();


        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            FrmCard card = new FrmCard();
            card.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            Attendance barCode = new Attendance();
            barCode.fillClass();
            barCode.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            FrmClassFees cf = new FrmClassFees();
            cf.ShowDialog();
        }
    }
}
