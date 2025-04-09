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
    public partial class frmPlayerTurn : Form
    {
        public frmPlayerTurn()
        {
            InitializeComponent();
        }

        private void frmPlayerTurn_Load(object sender, EventArgs e)
        {
            MusicManager.PlayBackgroundMusic("Assets/battle_theme.wav");
        }

        private void frmPlayerTurn_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicManager.StopBackgroundMusic();
        }
    }
}
