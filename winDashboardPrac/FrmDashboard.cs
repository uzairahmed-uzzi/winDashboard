using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winDashboardPrac
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flpSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Dock = DockStyle.Fill;
            frmLogin.TopMost = true;
            frmLogin.TopLevel = false;
            frmLogin.ControlBox = false;
            frmLogin.ShowIcon = false;
            
            this.pnlParentForm.Controls.Add(frmLogin);
            frmLogin.Show();

        }
 
private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState
.Minimized;
        }
    }
}
