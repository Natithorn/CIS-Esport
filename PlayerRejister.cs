using CIS_Esport.Class;

namespace CIS_Esport
{
    public partial class PlayerRejister : Form
    {
        PlayInfo player;
        public PlayerRejister()
        {
            InitializeComponent();
        }

        private void PlayerRejister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;
            string LastName = tbLastName.Text;
            string Id = tbID.Text;
            string Mj = tbMj.Text;
            string displayname = tbDisplay.Text;
            string Team = tbTeam.Text;
            string Mail = tbMail.Text;
            string Tel = tbTel.Text;
            int Age = int.Parse(tbAge.Text);

            player = new PlayInfo()
            {
                name = Name,
                Lastname = LastName,
                Id = Id,
                Mj = Mj,
                displayname = displayname,
                Team = Team,
                Mail = Mail,
                Tel = Tel,
                Age = Age,

            };
            this.DialogResult= DialogResult.OK;

        }
        public PlayInfo getPlayer()
        {
            return player;
        }
    }
}