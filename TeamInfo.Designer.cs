namespace CIS_Esport
{
    partial class TeamInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Player1,
            this.Player2,
            this.Player3,
            this.Player4,
            this.Player5});
            this.dataGridView1.Location = new System.Drawing.Point(28, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(966, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.MinimumWidth = 8;
            this.Team.Name = "Team";
            this.Team.Width = 150;
            // 
            // Player1
            // 
            this.Player1.HeaderText = "Player1";
            this.Player1.MinimumWidth = 8;
            this.Player1.Name = "Player1";
            this.Player1.Width = 150;
            // 
            // Player2
            // 
            this.Player2.HeaderText = "Player2";
            this.Player2.MinimumWidth = 8;
            this.Player2.Name = "Player2";
            this.Player2.Width = 150;
            // 
            // Player3
            // 
            this.Player3.HeaderText = "Player3";
            this.Player3.MinimumWidth = 8;
            this.Player3.Name = "Player3";
            this.Player3.Width = 150;
            // 
            // Player4
            // 
            this.Player4.HeaderText = "Player4";
            this.Player4.MinimumWidth = 8;
            this.Player4.Name = "Player4";
            this.Player4.Width = 150;
            // 
            // Player5
            // 
            this.Player5.HeaderText = "Player5";
            this.Player5.MinimumWidth = 8;
            this.Player5.Name = "Player5";
            this.Player5.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newTeamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // newTeamToolStripMenuItem
            // 
            this.newTeamToolStripMenuItem.Name = "newTeamToolStripMenuItem";
            this.newTeamToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.newTeamToolStripMenuItem.Text = "New Team";
            this.newTeamToolStripMenuItem.Click += new System.EventHandler(this.newTeamToolStripMenuItem_Click);
            // 
            // TeamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeamInfo";
            this.Text = "TeamInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private DataGridViewTextBoxColumn Team;
        private DataGridViewTextBoxColumn Player1;
        private DataGridViewTextBoxColumn Player2;
        private DataGridViewTextBoxColumn Player3;
        private DataGridViewTextBoxColumn Player4;
        private DataGridViewTextBoxColumn Player5;
        private ToolStripMenuItem newTeamToolStripMenuItem;
    }
}