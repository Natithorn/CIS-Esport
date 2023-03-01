using CIS_Esport.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_Esport
{
   

    public partial class TeamInfo : Form // Team DATAGrids
    {
        List<TeamInfo> teams = new List<TeamInfo>();
        public TeamInfo()
        {
            InitializeComponent();
        }

        private void newTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Team te = new Team();
            te.ShowDialog();
            if(te.DialogResult== DialogResult.OK)
            {
                TeamInfo2 Teams = te.getTeam();
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(Teams.TeamName, Teams.Member[0].name,
                    Teams.Member[1].name, Teams.Member[2].name, Teams.Member[3].name, Teams.Member[4].name);

            }
        }

        private void RefreshDataG()
        {
            dataGridView1.Rows.Clear();
            foreach (TeamInfo Teams in teams)
            {
                dataGridView1.Rows.Add(Teams.TeamName, Teams.Member[0].name,
                    Teams.Member[1].name, Teams.Member[2].name, Teams.Member[3].name, Teams.Member[4].name);


            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Teams";
            savefile.Filter = "Json|*.json";
            savefile.ShowDialog();

            if (savefile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(teams, Formatting.Indented);
                File.WriteAllText(savefile.FileName, json);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Teams";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                teams = JsonConvert.DeserializeObject<List<TeamInfo>>(File.ReadAllText(openfile.FileName));
                RefreshDataGrid();
            }
        }
    }
}
