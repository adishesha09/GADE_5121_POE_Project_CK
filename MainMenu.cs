namespace GADE_5121_POE_Project_CK
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            MusicManager.PlayBackgroundMusic("Assets/main_menu.wav");
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicManager.StopBackgroundMusic();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            SoundEffectsManager.PlaySound("Assets/form_button.wav");
            Form battle = new frmBattle();
            battle.Show();
            this.Hide();
        }
    }
}
