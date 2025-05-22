namespace GADE_5121_POE_Project_CK
{
    partial class frmPlayerTurn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerTurn));
            grpPlayerTurn = new GroupBox();
            btnBlock = new Button();
            btnSpecialAttack = new Button();
            btnAttack = new Button();
            lblPlayerHP = new Label();
            grpOpponent = new GroupBox();
            lblOpponentHP = new Label();
            lblOpponentDragonName = new Label();
            grpBattleLog = new GroupBox();
            txtBattleLog = new RichTextBox();
            btnRest = new Button();
            grpPlayerTurn.SuspendLayout();
            grpOpponent.SuspendLayout();
            grpBattleLog.SuspendLayout();
            SuspendLayout();
            // 
            // grpPlayerTurn
            // 
            grpPlayerTurn.Controls.Add(btnRest);
            grpPlayerTurn.Controls.Add(btnBlock);
            grpPlayerTurn.Controls.Add(btnSpecialAttack);
            grpPlayerTurn.Controls.Add(btnAttack);
            grpPlayerTurn.Controls.Add(lblPlayerHP);
            grpPlayerTurn.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPlayerTurn.Location = new Point(42, 40);
            grpPlayerTurn.Margin = new Padding(4);
            grpPlayerTurn.Name = "grpPlayerTurn";
            grpPlayerTurn.Padding = new Padding(4);
            grpPlayerTurn.Size = new Size(478, 445);
            grpPlayerTurn.TabIndex = 0;
            grpPlayerTurn.TabStop = false;
            grpPlayerTurn.Text = "Player's Turn";
            // 
            // btnBlock
            // 
            btnBlock.Location = new Point(55, 270);
            btnBlock.Margin = new Padding(4);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(372, 76);
            btnBlock.TabIndex = 3;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            // 
            // btnSpecialAttack
            // 
            btnSpecialAttack.Location = new Point(55, 176);
            btnSpecialAttack.Margin = new Padding(4);
            btnSpecialAttack.Name = "btnSpecialAttack";
            btnSpecialAttack.Size = new Size(372, 74);
            btnSpecialAttack.TabIndex = 2;
            btnSpecialAttack.Text = "Special Attack";
            btnSpecialAttack.UseVisualStyleBackColor = true;
            btnSpecialAttack.Click += btnSpecialAttack_Click;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(55, 76);
            btnAttack.Margin = new Padding(4);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(372, 78);
            btnAttack.TabIndex = 1;
            btnAttack.Text = "Attack ";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // lblPlayerHP
            // 
            lblPlayerHP.AutoSize = true;
            lblPlayerHP.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerHP.Location = new Point(197, 26);
            lblPlayerHP.Margin = new Padding(4, 0, 4, 0);
            lblPlayerHP.Name = "lblPlayerHP";
            lblPlayerHP.Size = new Size(56, 34);
            lblPlayerHP.TabIndex = 0;
            lblPlayerHP.Text = "HP:";
            // 
            // grpOpponent
            // 
            grpOpponent.Controls.Add(lblOpponentHP);
            grpOpponent.Controls.Add(lblOpponentDragonName);
            grpOpponent.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpOpponent.Location = new Point(558, 114);
            grpOpponent.Margin = new Padding(4);
            grpOpponent.Name = "grpOpponent";
            grpOpponent.Padding = new Padding(4);
            grpOpponent.Size = new Size(398, 218);
            grpOpponent.TabIndex = 1;
            grpOpponent.TabStop = false;
            grpOpponent.Text = "Opponent";
            // 
            // lblOpponentHP
            // 
            lblOpponentHP.AutoSize = true;
            lblOpponentHP.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpponentHP.Location = new Point(138, 102);
            lblOpponentHP.Margin = new Padding(4, 0, 4, 0);
            lblOpponentHP.Name = "lblOpponentHP";
            lblOpponentHP.Size = new Size(65, 40);
            lblOpponentHP.TabIndex = 1;
            lblOpponentHP.Text = "HP:";
            // 
            // lblOpponentDragonName
            // 
            lblOpponentDragonName.AutoSize = true;
            lblOpponentDragonName.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpponentDragonName.Location = new Point(86, 56);
            lblOpponentDragonName.Margin = new Padding(4, 0, 4, 0);
            lblOpponentDragonName.Name = "lblOpponentDragonName";
            lblOpponentDragonName.Size = new Size(167, 24);
            lblOpponentDragonName.TabIndex = 0;
            lblOpponentDragonName.Text = "Opponent Dragon";
            // 
            // grpBattleLog
            // 
            grpBattleLog.Controls.Add(txtBattleLog);
            grpBattleLog.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBattleLog.Location = new Point(42, 518);
            grpBattleLog.Margin = new Padding(4);
            grpBattleLog.Name = "grpBattleLog";
            grpBattleLog.Padding = new Padding(4);
            grpBattleLog.Size = new Size(912, 228);
            grpBattleLog.TabIndex = 2;
            grpBattleLog.TabStop = false;
            grpBattleLog.Text = "Battle Log";
            // 
            // txtBattleLog
            // 
            txtBattleLog.Location = new Point(8, 31);
            txtBattleLog.Margin = new Padding(4);
            txtBattleLog.Name = "txtBattleLog";
            txtBattleLog.ReadOnly = true;
            txtBattleLog.Size = new Size(896, 170);
            txtBattleLog.TabIndex = 0;
            txtBattleLog.Text = "";
            // 
            // btnRest
            // 
            btnRest.Location = new Point(55, 369);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(372, 56);
            btnRest.TabIndex = 4;
            btnRest.Text = "Rest";
            btnRest.UseVisualStyleBackColor = true;
            // 
            // frmPlayerTurn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 778);
            Controls.Add(grpBattleLog);
            Controls.Add(grpOpponent);
            Controls.Add(grpPlayerTurn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPlayerTurn";
            Text = "Dragon Battle!";
            FormClosing += frmPlayerTurn_FormClosing;
            Load += frmPlayerTurn_Load;
            grpPlayerTurn.ResumeLayout(false);
            grpPlayerTurn.PerformLayout();
            grpOpponent.ResumeLayout(false);
            grpOpponent.PerformLayout();
            grpBattleLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPlayerTurn;
        private Button btnSpecialAttack;
        private Button btnAttack;
        private Label lblPlayerHP;
        private Button btnBlock;
        private GroupBox grpOpponent;
        private Label lblOpponentDragonName;
        private Label lblOpponentHP;
        private GroupBox grpBattleLog;
        private RichTextBox txtBattleLog;
        private Button btnRest;
    }
}