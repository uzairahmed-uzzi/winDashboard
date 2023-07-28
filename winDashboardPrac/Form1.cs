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
    public partial class Form1 : Form
    {
        private Panel leftBorderPanel;
        bool panelExtend=false;
        private Button currentBtn; 
        public Form1()
        {
            InitializeComponent();
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(7, 51);
            
            //flpSidePanel.Controls.Add(leftBorderPanel);
        }
        private void ActivateButton(object sender, Color color) { 
            if(sender != null)
            {
                currentBtn = sender as Button;
                currentBtn.Parent.Controls.Add(leftBorderPanel);
                leftBorderPanel.BackColor = color;
                leftBorderPanel.Location = new Point(0,currentBtn.Location.Y );
                leftBorderPanel.Visible = true;
                leftBorderPanel.BringToFront();
            }
        }
        /*
        private void timerSidePanel_Tick(object sender, EventArgs e)
        {
            if(panelExtend)
            {
                flpSidePanel.Width += 10;
                if (flpSidePanel.Width==flpSidePanel.MaximumSize.Width)
                {
                    panelExtend = false;
                    timerSidePanel.Stop();

                }
                
            }else
            {
                flpSidePanel.Width -= 10;
                if (flpSidePanel.Width == flpSidePanel.MinimumSize.Width)
                {
                    panelExtend = true;
                    timerSidePanel.Stop();
                }
                
             
                
            }

        }*/

        private void pboxMenu_Click(object sender, EventArgs e)
        {
           // timerSidePanel.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            timerSubHome.Start();

        }

        private void timerSubHome_Tick(object sender, EventArgs e)
        {
            if (panelExtend)
            {
                flpSubHome.Height += 10;
                if (flpSubHome.Height == flpSubHome.MaximumSize.Height)
                {
                    panelExtend = false;
                    timerSubHome.Stop();

                }

            }
            else
            {
                flpSubHome.Height -= 10;
                if (flpSubHome.Height == flpSubHome.MinimumSize.Height)
                {
                    panelExtend = true;
                    timerSubHome.Stop();
                }



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);

        }
    }
}
