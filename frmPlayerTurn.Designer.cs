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
            grpPlayerTurn.SuspendLayout();
            grpOpponent.SuspendLayout();
            grpBattleLog.SuspendLayout();
            SuspendLayout();
            // 
            // grpPlayerTurn
            // 
            grpPlayerTurn.Controls.Add(btnBlock);
            grpPlayerTurn.Controls.Add(btnSpecialAttack);
            grpPlayerTurn.Controls.Add(btnAttack);
            grpPlayerTurn.Controls.Add(lblPlayerHP);
            grpPlayerTurn.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPlayerTurn.Location = new Point(34, 32);
            grpPlayerTurn.Name = "grpPlayerTurn";
            grpPlayerTurn.Size = new Size(382, 356);
            grpPlayerTurn.TabIndex = 0;
            grpPlayerTurn.TabStop = false;
            grpPlayerTurn.Text = "Player's Turn";
            // 
            // btnBlock
            // 
            btnBlock.Location = new Point(44, 258);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(298, 61);
            btnBlock.TabIndex = 3;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSpecialAttack
            // 
            btnSpecialAttack.Location = new Point(44, 174);
            btnSpecialAttack.Name = "btnSpecialAttack";
            btnSpecialAttack.Size = new Size(298, 59);
            btnSpecialAttack.TabIndex = 2;
            btnSpecialAttack.Text = "Special Attack";
            btnSpecialAttack.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(44, 90);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(298, 62);
            btnAttack.TabIndex = 1;
            btnAttack.Text = "Attack ";
            btnAttack.UseVisualStyleBackColor = true;
            // 
            // lblPlayerHP
            // 
            lblPlayerHP.AutoSize = true;
            lblPlayerHP.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerHP.Location = new Point(123, 42);
            lblPlayerHP.Name = "lblPlayerHP";
            lblPlayerHP.Size = new Size(46, 28);
            lblPlayerHP.TabIndex = 0;
            lblPlayerHP.Text = "HP:";
            // 
            // grpOpponent
            // 
            grpOpponent.Controls.Add(lblOpponentHP);
            grpOpponent.Controls.Add(lblOpponentDragonName);
            grpOpponent.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpOpponent.Location = new Point(446, 91);
            grpOpponent.Name = "grpOpponent";
            grpOpponent.Size = new Size(318, 174);
            grpOpponent.TabIndex = 1;
            grpOpponent.TabStop = false;
            grpOpponent.Text = "Opponent";
            // 
            // lblOpponentHP
            // 
            lblOpponentHP.AutoSize = true;
            lblOpponentHP.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpponentHP.Location = new Point(132, 95);
            lblOpponentHP.Name = "lblOpponentHP";
            lblOpponentHP.Size = new Size(56, 34);
            lblOpponentHP.TabIndex = 1;
            lblOpponentHP.Text = "HP:";
            // 
            // lblOpponentDragonName
            // 
            lblOpponentDragonName.AutoSize = true;
            lblOpponentDragonName.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpponentDragonName.Location = new Point(69, 45);
            lblOpponentDragonName.Name = "lblOpponentDragonName";
            lblOpponentDragonName.Size = new Size(193, 28);
            lblOpponentDragonName.TabIndex = 0;
            lblOpponentDragonName.Text = "Opponent Dragon";
            // 
            // grpBattleLog
            // 
            grpBattleLog.Controls.Add(txtBattleLog);
            grpBattleLog.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBattleLog.Location = new Point(34, 414);
            grpBattleLog.Name = "grpBattleLog";
            grpBattleLog.Size = new Size(730, 182);
            grpBattleLog.TabIndex = 2;
            grpBattleLog.TabStop = false;
            grpBattleLog.Text = "Battle Log";
            // 
            // txtBattleLog
            // 
            txtBattleLog.Location = new Point(6, 25);
            txtBattleLog.Name = "txtBattleLog";
            txtBattleLog.ReadOnly = true;
            txtBattleLog.Size = new Size(718, 137);
            txtBattleLog.TabIndex = 0;
            txtBattleLog.Text = "";
            // 
            // frmPlayerTurn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 622);
            Controls.Add(grpBattleLog);
            Controls.Add(grpOpponent);
            Controls.Add(grpPlayerTurn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}