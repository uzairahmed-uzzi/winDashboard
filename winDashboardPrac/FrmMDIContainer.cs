using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winDashboardPrac
{
    public partial class FrmMDIContainer : Form
    {
        private int childFormNumber = 0;

        public FrmMDIContainer()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMDIContainer_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=DESKTOP-IINCDOC\SQLEXPRESS;Initial Catalog=imsdb;User ID=sa;Password=Sql123456";
            SqlConnection con = new SqlConnection(conStr);
            string name = "Iphone 14 pro Max";
            string category = "Smartphones";
            string query = $"insert into items(name,category) values('{name}','{category}')";
            string query2 = $"select * from dbo.items";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection Established");
            }
            int rows=cmd.ExecuteNonQuery();
            if (rows != null)
            {
                MessageBox.Show(Convert.ToString(rows));
            }

            con.Close();
            if (con.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection is Closed");
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query2,con);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            gvData.DataSource = dt;

            
        }
    }
}


