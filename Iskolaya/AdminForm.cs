using MetroFramework.Forms;
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
    public partial class AdminForm : MetroForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UserForm u = new UserForm();
            u.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UserForm u = new UserForm();
            u.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            TeachersForm t = new TeachersForm();
            t.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }
    }
}
