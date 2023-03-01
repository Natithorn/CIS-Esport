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
    public partial class Player : Form
    {
        public static Player Instance;
        public List<PlayInfo> listPlayer = new List<PlayInfo>();
        public Player()
        {
            InitializeComponent();
            Instance = this;
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerRejister PlayerreGis = new PlayerRejister();
            PlayerreGis.ShowDialog();   


            if(PlayerreGis.DialogResult == DialogResult.OK) 
            {
                listPlayer.Add(PlayerreGis.getPlayer());
                RefreshDataG();
             
            }

        }
        private void RefreshDataG()
        {
            dataGridView1.Rows.Clear();
            foreach(PlayInfo player_ in listPlayer)
            {
                dataGridView1.Rows.Add(player_.name,player_.Lastname,player_.Id
                    ,player_.Mj,player_.displayname,player_.Team,
                    player_.Mail,player_.Tel,player_.Age);
                    
                    
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Player";
            savefile.Filter = "Json|*.json";
            savefile.ShowDialog();

            if (savefile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(listPlayer, Formatting.Indented);
                File.WriteAllText(savefile.FileName,json) ;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Player";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if(openfile.FileName != "")
            {
                listPlayer = JsonConvert.DeserializeObject<List<PlayInfo>>(File.ReadAllText(openfile.FileName));
                RefreshDataG();
            }
        }

        private void manageTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamInfo teamRe = new TeamInfo();
            teamRe.ShowDialog();
        }
    }
}
