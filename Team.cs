using CIS_Esport.Class;
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
    public partial class Team : Form  // Team Register
    {
        TeamInfo2 team;
        List<PlayInfo> listplayer = new List<PlayInfo>();
        public Team()
        {
            InitializeComponent();
            for(int i = 0; i < 5;i++)
            {
                PlayInfo player = new PlayInfo();
                player.name = "";
                player.Lastname = "";
                player.Id = "";
                player.Mj = "";
                player.displayname = "";
                player.Team = "";
                player.Mail = "";
                player.Tel= "";
                player.Age = 0;
                listplayer.Add(player);
             
            }
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            string Teamname = tbTeamname.Text;
            team = new TeamInfo2(); 
            team.TeamName = Teamname;
            team.Member = this.listplayer;
            this.team = team;
            this.DialogResult = DialogResult.OK;

        }

        private void EvenOnclick(object sender, EventArgs e)
        {
            Button bott = (Button)sender;
            if (bott.Name == "Findbt1")
            {
                
                FindPlayer(0, tbMember1);

            } else if (bott.Name == "Findbt2")
            {
                
                FindPlayer(1, tbMember2);


            }
            else if (bott.Name == "Findbt3")
            {
                FindPlayer(2, tbMember3);

            }
            else if (bott.Name == "Findbt4")
            {
                FindPlayer(3, tbMember4);

            }
            else if (bott.Name == "Findbt5") 
            {
                FindPlayer(4, tbMember5);


            }
        }
        private void FindPlayer(int index, TextBox textBox)
        {
            FindPlayers Fpr = new FindPlayers();
            Fpr.ShowDialog();
            if(Fpr.DialogResult== DialogResult.OK)
            {
                listplayer[index] = Fpr.getPlayer();
                textBox.Text = Fpr.getPlayer().name;
                
            }
        }
        public TeamInfo2 getTeam() { return team; }
    }
}
