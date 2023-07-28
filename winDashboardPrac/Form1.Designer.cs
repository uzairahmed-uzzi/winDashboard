namespace winDashboardPrac
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flpSidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxMenu = new System.Windows.Forms.PictureBox();
            this.flpSubHome = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSubHome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.timerSidePanel = new System.Windows.Forms.Timer(this.components);
            this.timerSubHome = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpSidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMenu)).BeginInit();
            this.flpSubHome.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSidePanel
            // 
            this.flpSidePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flpSidePanel.Controls.Add(this.panel1);
            this.flpSidePanel.Controls.Add(this.flpSubHome);
            this.flpSidePanel.Controls.Add(this.panel4);
            this.flpSidePanel.Controls.Add(this.panel5);
            this.flpSidePanel.Controls.Add(this.panel3);
            this.flpSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSidePanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpSidePanel.Location = new System.Drawing.Point(0, 0);
            this.flpSidePanel.MaximumSize = new System.Drawing.Size(260, 0);
            this.flpSidePanel.MinimumSize = new System.Drawing.Size(84, 0);
            this.flpSidePanel.Name = "flpSidePanel";
            this.flpSidePanel.Size = new System.Drawing.Size(260, 685);
            this.flpSidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pboxMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 107);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // pboxMenu
            // 
            this.pboxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxMenu.Image = global::winDashboardPrac.Properties.Resources.menu1;
            this.pboxMenu.Location = new System.Drawing.Point(16, 37);
            this.pboxMenu.Name = "pboxMenu";
            this.pboxMenu.Size = new System.Drawing.Size(56, 48);
            this.pboxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxMenu.TabIndex = 0;
            this.pboxMenu.TabStop = false;
            this.pboxMenu.Click += new System.EventHandler(this.pboxMenu_Click);
            // 
            // flpSubHome
            // 
            this.flpSubHome.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flpSubHome.Controls.Add(this.panel2);
            this.flpSubHome.Controls.Add(this.panel6);
            this.flpSubHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSubHome.Location = new System.Drawing.Point(3, 118);
            this.flpSubHome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flpSubHome.MaximumSize = new System.Drawing.Size(258, 108);
            this.flpSubHome.MinimumSize = new System.Drawing.Size(84, 60);
            this.flpSubHome.Name = "flpSubHome";
            this.flpSubHome.Size = new System.Drawing.Size(258, 60);
            this.flpSubHome.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 51);
            this.panel2.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::winDashboardPrac.Properties.Resources.icons8_home_35;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(259, 51);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "  HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSubHome);
            this.panel6.Location = new System.Drawing.Point(3, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 40);
            this.panel6.TabIndex = 5;
            // 
            // btnSubHome
            // 
            this.btnSubHome.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSubHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubHome.FlatAppearance.BorderSize = 0;
            this.btnSubHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubHome.Image = global::winDashboardPrac.Properties.Resources.icons8_dot_30;
            this.btnSubHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHome.Location = new System.Drawing.Point(0, 0);
            this.btnSubHome.Name = "btnSubHome";
            this.btnSubHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSubHome.Size = new System.Drawing.Size(258, 40);
            this.btnSubHome.TabIndex = 2;
            this.btnSubHome.Text = "SubField";
            this.btnSubHome.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHelp);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 188);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 60);
            this.panel4.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHelp.Image = global::winDashboardPrac.Properties.Resources.icons8_help_35;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(258, 60);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "  HELP";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAbout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 258);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 60);
            this.panel5.TabIndex = 4;
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Image = global::winDashboardPrac.Properties.Resources.icons8_about_35;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(258, 60);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "  ABOUT";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSetting);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 328);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 60);
            this.panel3.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetting.Image = global::winDashboardPrac.Properties.Resources.icons8_setting_35;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(258, 60);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "  SETTING";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // timerSidePanel
            // 
            this.timerSidePanel.Interval = 10;
            // 
            // timerSubHome
            // 
            this.timerSubHome.Interval = 10;
            this.timerSubHome.Tick += new System.EventHandler(this.timerSubHome_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(271, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 665);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flpSidePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flpSidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMenu)).EndInit();
            this.flpSubHome.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pboxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpSubHome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSubHome;
        private System.Windows.Forms.Timer timerSidePanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Timer timerSubHome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

