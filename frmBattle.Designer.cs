namespace GADE_5121_POE_Project_CK
{
    partial class frmBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle));
            grpPlayer1 = new GroupBox();
            btnSave1 = new Button();
            grpPlayer1DragonType = new GroupBox();
            rbEarth1 = new RadioButton();
            rbWind1 = new RadioButton();
            rbIce1 = new RadioButton();
            rbFire1 = new RadioButton();
            txtPlayer1Dragon = new TextBox();
            lblPlayer1DragonName = new Label();
            txtPlayer1Name = new TextBox();
            lblPlayer1Name = new Label();
            grpPlayer2 = new GroupBox();
            btnSave2 = new Button();
            grpPlayer2DragonType = new GroupBox();
            rbEarth2 = new RadioButton();
            rbWind2 = new RadioButton();
            rbIce2 = new RadioButton();
            rbFire2 = new RadioButton();
            txtPlayer2Dragon = new TextBox();
            lblPlayer2DragonName = new Label();
            txtPlayer2Name = new TextBox();
            lblPlayer2Name = new Label();
            lblDragonStats = new Label();
            btnStart = new Button();
            grpPlayer1.SuspendLayout();
            grpPlayer1DragonType.SuspendLayout();
            grpPlayer2.SuspendLayout();
            grpPlayer2DragonType.SuspendLayout();
            SuspendLayout();
            // 
            // grpPlayer1
            // 
            grpPlayer1.Controls.Add(btnSave1);
            grpPlayer1.Controls.Add(grpPlayer1DragonType);
            grpPlayer1.Controls.Add(txtPlayer1Dragon);
            grpPlayer1.Controls.Add(lblPlayer1DragonName);
            grpPlayer1.Controls.Add(txtPlayer1Name);
            grpPlayer1.Controls.Add(lblPlayer1Name);
            grpPlayer1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPlayer1.Location = new Point(40, 44);
            grpPlayer1.Name = "grpPlayer1";
            grpPlayer1.Size = new Size(357, 436);
            grpPlayer1.TabIndex = 0;
            grpPlayer1.TabStop = false;
            grpPlayer1.Text = "Player 1";
            // 
            // btnSave1
            // 
            btnSave1.Location = new Point(6, 358);
            btnSave1.Name = "btnSave1";
            btnSave1.Size = new Size(345, 43);
            btnSave1.TabIndex = 4;
            btnSave1.Text = "Save";
            btnSave1.UseVisualStyleBackColor = true;
            // 
            // grpPlayer1DragonType
            // 
            grpPlayer1DragonType.Controls.Add(rbEarth1);
            grpPlayer1DragonType.Controls.Add(rbWind1);
            grpPlayer1DragonType.Controls.Add(rbIce1);
            grpPlayer1DragonType.Controls.Add(rbFire1);
            grpPlayer1DragonType.Location = new Point(6, 127);
            grpPlayer1DragonType.Name = "grpPlayer1DragonType";
            grpPlayer1DragonType.Size = new Size(345, 217);
            grpPlayer1DragonType.TabIndex = 4;
            grpPlayer1DragonType.TabStop = false;
            grpPlayer1DragonType.Text = "Dragon Type";
            // 
            // rbEarth1
            // 
            rbEarth1.AutoSize = true;
            rbEarth1.Location = new Point(6, 161);
            rbEarth1.Name = "rbEarth1";
            rbEarth1.Size = new Size(117, 22);
            rbEarth1.TabIndex = 3;
            rbEarth1.TabStop = true;
            rbEarth1.Text = "Earth Dragon";
            rbEarth1.UseVisualStyleBackColor = true;
            // 
            // rbWind1
            // 
            rbWind1.AutoSize = true;
            rbWind1.Location = new Point(6, 123);
            rbWind1.Name = "rbWind1";
            rbWind1.Size = new Size(114, 22);
            rbWind1.TabIndex = 2;
            rbWind1.TabStop = true;
            rbWind1.Text = "Wind Dragon";
            rbWind1.UseVisualStyleBackColor = true;
            // 
            // rbIce1
            // 
            rbIce1.AutoSize = true;
            rbIce1.Location = new Point(6, 82);
            rbIce1.Name = "rbIce1";
            rbIce1.Size = new Size(100, 22);
            rbIce1.TabIndex = 1;
            rbIce1.TabStop = true;
            rbIce1.Text = "Ice Dragon";
            rbIce1.UseVisualStyleBackColor = true;
            // 
            // rbFire1
            // 
            rbFire1.AutoSize = true;
            rbFire1.Location = new Point(6, 44);
            rbFire1.Name = "rbFire1";
            rbFire1.Size = new Size(107, 22);
            rbFire1.TabIndex = 0;
            rbFire1.TabStop = true;
            rbFire1.Text = "Fire Dragon";
            rbFire1.UseVisualStyleBackColor = true;
            // 
            // txtPlayer1Dragon
            // 
            txtPlayer1Dragon.Location = new Point(109, 79);
            txtPlayer1Dragon.MaxLength = 15;
            txtPlayer1Dragon.Name = "txtPlayer1Dragon";
            txtPlayer1Dragon.Size = new Size(234, 26);
            txtPlayer1Dragon.TabIndex = 3;
            // 
            // lblPlayer1DragonName
            // 
            lblPlayer1DragonName.AutoSize = true;
            lblPlayer1DragonName.Location = new Point(6, 81);
            lblPlayer1DragonName.Name = "lblPlayer1DragonName";
            lblPlayer1DragonName.Size = new Size(103, 18);
            lblPlayer1DragonName.TabIndex = 2;
            lblPlayer1DragonName.Text = "Dragon Name:";
            // 
            // txtPlayer1Name
            // 
            txtPlayer1Name.Location = new Point(109, 35);
            txtPlayer1Name.MaxLength = 25;
            txtPlayer1Name.Name = "txtPlayer1Name";
            txtPlayer1Name.Size = new Size(234, 26);
            txtPlayer1Name.TabIndex = 1;
            // 
            // lblPlayer1Name
            // 
            lblPlayer1Name.AutoSize = true;
            lblPlayer1Name.Location = new Point(6, 38);
            lblPlayer1Name.Name = "lblPlayer1Name";
            lblPlayer1Name.Size = new Size(97, 18);
            lblPlayer1Name.TabIndex = 0;
            lblPlayer1Name.Text = "Player Name:";
            // 
            // grpPlayer2
            // 
            grpPlayer2.Controls.Add(btnSave2);
            grpPlayer2.Controls.Add(grpPlayer2DragonType);
            grpPlayer2.Controls.Add(txtPlayer2Dragon);
            grpPlayer2.Controls.Add(lblPlayer2DragonName);
            grpPlayer2.Controls.Add(txtPlayer2Name);
            grpPlayer2.Controls.Add(lblPlayer2Name);
            grpPlayer2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPlayer2.Location = new Point(409, 44);
            grpPlayer2.Name = "grpPlayer2";
            grpPlayer2.Size = new Size(357, 436);
            grpPlayer2.TabIndex = 1;
            grpPlayer2.TabStop = false;
            grpPlayer2.Text = "Player 2";
            // 
            // btnSave2
            // 
            btnSave2.Location = new Point(6, 358);
            btnSave2.Name = "btnSave2";
            btnSave2.Size = new Size(345, 43);
            btnSave2.TabIndex = 5;
            btnSave2.Text = "Save";
            btnSave2.UseVisualStyleBackColor = true;
            // 
            // grpPlayer2DragonType
            // 
            grpPlayer2DragonType.Controls.Add(rbEarth2);
            grpPlayer2DragonType.Controls.Add(rbWind2);
            grpPlayer2DragonType.Controls.Add(rbIce2);
            grpPlayer2DragonType.Controls.Add(rbFire2);
            grpPlayer2DragonType.Location = new Point(6, 127);
            grpPlayer2DragonType.Name = "grpPlayer2DragonType";
            grpPlayer2DragonType.Size = new Size(345, 217);
            grpPlayer2DragonType.TabIndex = 4;
            grpPlayer2DragonType.TabStop = false;
            grpPlayer2DragonType.Text = "Dragon Type";
            // 
            // rbEarth2
            // 
            rbEarth2.AutoSize = true;
            rbEarth2.Location = new Point(8, 161);
            rbEarth2.Name = "rbEarth2";
            rbEarth2.Size = new Size(117, 22);
            rbEarth2.TabIndex = 3;
            rbEarth2.TabStop = true;
            rbEarth2.Text = "Earth Dragon";
            rbEarth2.UseVisualStyleBackColor = true;
            // 
            // rbWind2
            // 
            rbWind2.AutoSize = true;
            rbWind2.Location = new Point(6, 123);
            rbWind2.Name = "rbWind2";
            rbWind2.Size = new Size(114, 22);
            rbWind2.TabIndex = 2;
            rbWind2.TabStop = true;
            rbWind2.Text = "Wind Dragon";
            rbWind2.UseVisualStyleBackColor = true;
            // 
            // rbIce2
            // 
            rbIce2.AutoSize = true;
            rbIce2.Location = new Point(6, 82);
            rbIce2.Name = "rbIce2";
            rbIce2.Size = new Size(100, 22);
            rbIce2.TabIndex = 1;
            rbIce2.TabStop = true;
            rbIce2.Text = "Ice Dragon";
            rbIce2.UseVisualStyleBackColor = true;
            // 
            // rbFire2
            // 
            rbFire2.AutoSize = true;
            rbFire2.Location = new Point(6, 44);
            rbFire2.Name = "rbFire2";
            rbFire2.Size = new Size(107, 22);
            rbFire2.TabIndex = 0;
            rbFire2.TabStop = true;
            rbFire2.Text = "Fire Dragon";
            rbFire2.UseVisualStyleBackColor = true;
            // 
            // txtPlayer2Dragon
            // 
            txtPlayer2Dragon.Location = new Point(109, 81);
            txtPlayer2Dragon.MaxLength = 15;
            txtPlayer2Dragon.Name = "txtPlayer2Dragon";
            txtPlayer2Dragon.Size = new Size(231, 26);
            txtPlayer2Dragon.TabIndex = 3;
            // 
            // lblPlayer2DragonName
            // 
            lblPlayer2DragonName.AutoSize = true;
            lblPlayer2DragonName.Location = new Point(6, 79);
            lblPlayer2DragonName.Name = "lblPlayer2DragonName";
            lblPlayer2DragonName.Size = new Size(107, 18);
            lblPlayer2DragonName.TabIndex = 2;
            lblPlayer2DragonName.Text = "Dragon Name: ";
            // 
            // txtPlayer2Name
            // 
            txtPlayer2Name.Location = new Point(109, 32);
            txtPlayer2Name.MaxLength = 25;
            txtPlayer2Name.Name = "txtPlayer2Name";
            txtPlayer2Name.Size = new Size(232, 26);
            txtPlayer2Name.TabIndex = 1;
            // 
            // lblPlayer2Name
            // 
            lblPlayer2Name.AutoSize = true;
            lblPlayer2Name.Location = new Point(6, 35);
            lblPlayer2Name.Name = "lblPlayer2Name";
            lblPlayer2Name.Size = new Size(97, 18);
            lblPlayer2Name.TabIndex = 0;
            lblPlayer2Name.Text = "Player Name:";
            // 
            // lblDragonStats
            // 
            lblDragonStats.Location = new Point(787, 43);
            lblDragonStats.Name = "lblDragonStats";
            lblDragonStats.Size = new Size(239, 437);
            lblDragonStats.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(40, 495);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(726, 51);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // frmBattle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 577);
            Controls.Add(btnStart);
            Controls.Add(lblDragonStats);
            Controls.Add(grpPlayer2);
            Controls.Add(grpPlayer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmBattle";
            Text = "Dragon Battle!";
            FormClosing += frmBattle_FormClosing;
            Load += frmBattle_Load;
            grpPlayer1.ResumeLayout(false);
            grpPlayer1.PerformLayout();
            grpPlayer1DragonType.ResumeLayout(false);
            grpPlayer1DragonType.PerformLayout();
            grpPlayer2.ResumeLayout(false);
            grpPlayer2.PerformLayout();
            grpPlayer2DragonType.ResumeLayout(false);
            grpPlayer2DragonType.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPlayer1;
        private GroupBox grpPlayer2;
        private Label lblDragonStats;
        private Button btnStart;
        private TextBox txtPlayer1Name;
        private Label lblPlayer1Name;
        private TextBox txtPlayer1Dragon;
        private Label lblPlayer1DragonName;
        private Label lblPlayer2DragonName;
        private TextBox txtPlayer2Name;
        private Label lblPlayer2Name;
        private GroupBox grpPlayer1DragonType;
        private TextBox txtPlayer2Dragon;
        private GroupBox grpPlayer2DragonType;
        private RadioButton rbIce1;
        private RadioButton rbFire1;
        private Button btnSave1;
        private RadioButton rbEarth1;
        private RadioButton rbWind1;
        private RadioButton rbFire2;
        private RadioButton rbIce2;
        private RadioButton rbEarth2;
        private RadioButton rbWind2;
        private Button btnSave2;
    }
}