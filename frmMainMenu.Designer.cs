namespace GADE_5121_POE_Project_CK
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            btnStartGame = new Button();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.BackgroundImage = (Image)resources.GetObject("btnStartGame.BackgroundImage");
            btnStartGame.BackgroundImageLayout = ImageLayout.Stretch;
            btnStartGame.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.Location = new Point(324, 358);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(181, 45);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStartGame);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMainMenu";
            Text = "Dragon Battle!";
            FormClosing += frmMainMenu_FormClosing;
            Load += frmMainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartGame;
    }
}
