namespace CIS_Esport
{
    partial class FindPlayers
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
            this.tbSub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(966, 264);
            this.dataGridView1.TabIndex = 1;
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
            // tbSub
            // 
            this.tbSub.Location = new System.Drawing.Point(115, 361);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(127, 46);
            this.tbSub.TabIndex = 2;
            this.tbSub.Text = "Submit";
            this.tbSub.UseVisualStyleBackColor = true;
            this.tbSub.Click += new System.EventHandler(this.tbSub_Click);
            // 
            // FindPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FindPlayers";
            this.Text = "FindPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Team;
        private DataGridViewTextBoxColumn Player1;
        private DataGridViewTextBoxColumn Player2;
        private DataGridViewTextBoxColumn Player3;
        private DataGridViewTextBoxColumn Player4;
        private DataGridViewTextBoxColumn Player5;
        private Button tbSub;
    }
}