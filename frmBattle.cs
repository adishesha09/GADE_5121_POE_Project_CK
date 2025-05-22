using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_5121_POE_Project_CK
{
    public partial class frmBattle : Form
    {
        public frmBattle()
        {
            InitializeComponent();

            // Disable Start Game button initially
            btnStart.Enabled = false;

            // Add Elemental Icons for Player Dragon Types
            AddDragonIcons();
            AddDragonIcons1();
        }

        // Arrays to store player and dragon information
        string[] P1data = new string[3]; // [0] Player name, [1] Dragon name, [2] Dragon type
        string[] P2data = new string[3];

        // Arrays to store dragon statistics [0] HP, [1] Attack, [2] Special Attack, [3] Block
        int[] P1values = new int[4];
        int[] P2values = new int[4];

        // Fire Dragon constants
        const string FIRE_DRAGON_TYPE = "Fire";
        const int FIRE_DRAGON_HP = 20;
        const int FIRE_DRAGON_ATK = 5;
        const int FIRE_DRAGON_SPATK = 12;
        const int FIRE_DRAGON_BLOCK = 4;

        // Ice Dragon constants
        const string ICE_DRAGON_TYPE = "Ice";
        const int ICE_DRAGON_HP = 30;
        const int ICE_DRAGON_ATK = 4;
        const int ICE_DRAGON_SPATK = 9;
        const int ICE_DRAGON_BLOCK = 5;

        // Wind Dragon constants
        const string WIND_DRAGON_TYPE = "Wind";
        const int WIND_DRAGON_HP = 40;
        const int WIND_DRAGON_ATK = 3;
        const int WIND_DRAGON_SPATK = 7;
        const int WIND_DRAGON_BLOCK = 5;

        // Earth Dragon constants
        const string EARTH_DRAGON_TYPE = "Earth";
        const int EARTH_DRAGON_HP = 50;
        const int EARTH_DRAGON_ATK = 2;
        const int EARTH_DRAGON_SPATK = 5;
        const int EARTH_DRAGON_BLOCK = 6;

        private void saveValues(string[] playerData, int[] playerValues, string playerName, string dragonName, string dragonType, bool isPlayer1)
        {
            // Save player and dragon names
            playerData[0] = playerName;
            playerData[1] = dragonName;
            playerData[2] = dragonType;

            // Set dragon stats based on type
            switch (dragonType)
            {
                case FIRE_DRAGON_TYPE:
                    playerValues[0] = FIRE_DRAGON_HP;
                    playerValues[1] = FIRE_DRAGON_ATK;
                    playerValues[2] = FIRE_DRAGON_SPATK;
                    playerValues[3] = FIRE_DRAGON_BLOCK;
                    break;
                case ICE_DRAGON_TYPE:
                    playerValues[0] = ICE_DRAGON_HP;
                    playerValues[1] = ICE_DRAGON_ATK;
                    playerValues[2] = ICE_DRAGON_SPATK;
                    playerValues[3] = ICE_DRAGON_BLOCK;
                    break;
                case WIND_DRAGON_TYPE:
                    playerValues[0] = WIND_DRAGON_HP;
                    playerValues[1] = WIND_DRAGON_ATK;
                    playerValues[2] = WIND_DRAGON_SPATK;
                    playerValues[3] = WIND_DRAGON_BLOCK;
                    break;
                case EARTH_DRAGON_TYPE:
                    playerValues[0] = EARTH_DRAGON_HP;
                    playerValues[1] = EARTH_DRAGON_ATK;
                    playerValues[2] = EARTH_DRAGON_SPATK;
                    playerValues[3] = EARTH_DRAGON_BLOCK;
                    break;
            }

            // Build the combined display text
            string statsText = $"{(isPlayer1 ? "Player 1" : "Player 2")}: {playerName}\n";
            statsText += $"Dragon: {dragonName} ({dragonType})\n\n";

            // Add the appropriate stats based on dragon type
            switch (dragonType)
            {
                case FIRE_DRAGON_TYPE:
                    statsText += $"Fire Dragon\n" +
                                $"{FIRE_DRAGON_HP} HP\n" +
                                $"{FIRE_DRAGON_ATK} Attack Damage\n" +
                                $"{FIRE_DRAGON_SPATK} Special Attack Damage\n" +
                                $"{FIRE_DRAGON_BLOCK} Block Damage";
                    break;
                case ICE_DRAGON_TYPE:
                    statsText += $"Ice Dragon\n" +
                                $"{ICE_DRAGON_HP} HP\n" +
                                $"{ICE_DRAGON_ATK} Attack Damage\n" +
                                $"{ICE_DRAGON_SPATK} Special Attack Damage\n" +
                                $"{ICE_DRAGON_BLOCK} Block Damage";
                    break;
                case WIND_DRAGON_TYPE:
                    statsText += $"Wind Dragon\n" +
                                $"{WIND_DRAGON_HP} HP\n" +
                                $"{WIND_DRAGON_ATK} Attack Damage\n" +
                                $"{WIND_DRAGON_SPATK} Special Attack Damage\n" +
                                $"{WIND_DRAGON_BLOCK} Block Damage";
                    break;
                case EARTH_DRAGON_TYPE:
                    statsText += $"Earth Dragon\n" +
                                $"{EARTH_DRAGON_HP} HP\n" +
                                $"{EARTH_DRAGON_ATK} Attack Damage\n" +
                                $"{EARTH_DRAGON_SPATK} Special Attack Damage\n" +
                                $"{EARTH_DRAGON_BLOCK} Block Damage";
                    break;
            }

            // Update the label with the combined information
            lblDragonStats.Text = statsText;
        }

        private void AddDragonIcons()
        {
            string[] imagePaths = { "Assets/fire.png", "Assets/ice.png", "Assets/wind.png", "Assets/earth.png" };
            RadioButton[] radioButtons = { rbFire1, rbIce1, rbWind1, rbEarth1 };
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (File.Exists(imagePaths[i])) // Check if file exists
                {
                    PictureBox pbIcon = new PictureBox();
                    pbIcon.Image = Image.FromFile(imagePaths[i]); // Load image
                    pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbIcon.Size = new Size(30, 30);
                    pbIcon.Location = new Point(170, radioButtons[i].Location.Y); // Align with radio button
                    pbIcon.BackColor = Color.Transparent;
                    grpPlayer1DragonType.Controls.Add(pbIcon); // Add PictureBox to the same group box
                }
            }
        }

        private void AddDragonIcons1()
        {
            string[] imagePaths1 = { "Assets/fire.png", "Assets/ice.png", "Assets/wind.png", "Assets/earth.png" };
            RadioButton[] radioButtons1 = { rbFire2, rbIce2, rbWind2, rbEarth2 };
            for (int i = 0; i < radioButtons1.Length; i++)
            {
                if (File.Exists(imagePaths1[i])) // Check if file exists
                {
                    PictureBox pbIcon = new PictureBox();
                    pbIcon.Image = Image.FromFile(imagePaths1[i]); // Load image
                    pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbIcon.Size = new Size(30, 30);
                    pbIcon.Location = new Point(170, radioButtons1[i].Location.Y); // Align with radio button
                    pbIcon.BackColor = Color.Transparent;
                    grpPlayer2DragonType.Controls.Add(pbIcon); // Add PictureBox to the same group box
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form player_turn = new frmPlayerTurn(P1data, P1values, P2data, P2values);
            player_turn.Show();
            this.Hide();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            string dragonType = "";
            if (rbFire1.Checked) dragonType = FIRE_DRAGON_TYPE;
            else if (rbIce1.Checked) dragonType = ICE_DRAGON_TYPE;
            else if (rbWind1.Checked) dragonType = WIND_DRAGON_TYPE;
            else if (rbEarth1.Checked) dragonType = EARTH_DRAGON_TYPE;

            saveValues(P1data, P1values, txtPlayer1Name.Text, txtPlayer1Dragon.Text, dragonType, true);
            btnSave1.Enabled = false;
            CheckStartGameEnabled();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            string dragonType = "";
            if (rbFire2.Checked) dragonType = FIRE_DRAGON_TYPE;
            else if (rbIce2.Checked) dragonType = ICE_DRAGON_TYPE;
            else if (rbWind2.Checked) dragonType = WIND_DRAGON_TYPE;
            else if (rbEarth2.Checked) dragonType = EARTH_DRAGON_TYPE;

            saveValues(P2data, P2values, txtPlayer2Name.Text, txtPlayer2Dragon.Text, dragonType, false);
            btnSave2.Enabled = false;
            CheckStartGameEnabled();
        }

        private void CheckStartGameEnabled()
        {
            btnStart.Enabled = !btnSave1.Enabled && !btnSave2.Enabled;
        }

        private void frmBattle_Load(object sender, EventArgs e)
        {
            MusicManager.PlayBackgroundMusic("Assets/battle_music.wav");
        }

        private void frmBattle_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicManager.StopBackgroundMusic();
        }
    }
}