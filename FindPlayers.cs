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
    public partial class FindPlayers : Form
    {
        PlayInfo player;
        public FindPlayers()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            foreach(PlayInfo player_ in Player.Instance.listPlayer)
            {
                dataGridView1.Rows.Add(player_.name, player_.Lastname, player_.Id
                    , player_.Mj, player_.displayname, player_.Team,
                    player_.Mail, player_.Tel, player_.Age);
            }
        }
        public PlayInfo getPlayer()
        {
            return player;
        }

        private void tbSub_Click(object sender, EventArgs e)
        {

            PlayInfo pP = Player.Instance.listPlayer[dataGridView1.CurrentRow.Index];
            player = pP;
            this.DialogResult= DialogResult.OK;


        }
    }

    
}
