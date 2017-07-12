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
    public partial class FrmClassFees : MetroFramework.Forms.MetroForm
    {
        public FrmClassFees()
        {
            InitializeComponent();
        }

        private void txtbarcode_leave(object sender, EventArgs e)
        {


            try
            {
                MysqlConn msc = new MysqlConn();
                msc.query = "select full_name from escolaya_db.student where barcode=" + txtbarcode.Text;

                MySqlConnection conn = new MySqlConnection(msc.con);
                conn.Open();
                msc.command = new MySqlCommand(msc.query, conn);
                msc.mdr = msc.command.ExecuteReader();

                msc.mdr.Read();

                lblname.Text = msc.mdr.GetString("full_name");



            }
            catch (Exception ex)
            {


            }
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
