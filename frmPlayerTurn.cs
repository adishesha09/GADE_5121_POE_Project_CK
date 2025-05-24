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
        // Player data arrays
        private string[] player1Data;
        private string[] player2Data;
        private int[] player1Values;
        private int[] player2Values;
        private bool isPlayer1Turn;

        // Track turn count and resting status
        private int turnCount = 0;
        private bool player1NeedsRest = false;
        private bool player2NeedsRest = false;
        private bool isRestingPhase = false;

        // New fields for tracking block status
        private bool player1IsBlocking = false;
        private bool player2IsBlocking = false;
        private bool opponentBlockedLastAttack = false;

        // Method that passes player data
        public frmPlayerTurn(string[] p1Data, int[] p1Values, string[] p2Data, int[] p2Values)
        {
            InitializeComponent();

            // Initially hide the rest button
            btnRest.Visible = false;

            // Store the passed data
            this.player1Data = p1Data;
            this.player1Values = p1Values;
            this.player2Data = p2Data;
            this.player2Values = p2Values;

            UpdateUIForCurrentPlayer();
        }

        private void Rest(bool isPlayer1)
        {
            string dragonName = isPlayer1 ? player1Data[1] : player2Data[1];
            txtBattleLog.AppendText($"{dragonName} is too tired to fight, and rests a while\n");

            // Reset resting flags
            if (isPlayer1)
                player1NeedsRest = false;
            else
                player2NeedsRest = false;

            // Pass turn to opponent
            isPlayer1Turn = !isPlayer1Turn; // Force turn switch
            isRestingPhase = false; // Clear resting phase

            // Update turn count and check for initiative roll
            turnCount++;
            if (turnCount % 2 == 0)
            {
                int startingPlayer = takeInitiative();
                isPlayer1Turn = (startingPlayer == 1);
            }

            UpdateAfterAction();
        }

        // Method to generate random dice roll (1-6)
        private int randomRoll()
        {
            Random random = new Random();
            return random.Next(1, 7); // Returns a random number between 1 and 6
        }

        // Method to determine which player starts the round
        private int takeInitiative()
        {
            int player1Roll, player2Roll;

            do
            {
                player1Roll = randomRoll();
                player2Roll = randomRoll();

                // Log the rolls to battle log
                txtBattleLog.AppendText($"Initiative roll: {player1Data[0]} rolled {player1Roll}, {player2Data[0]} rolled {player2Roll}\n");

                if (player1Roll > player2Roll)
                {
                    txtBattleLog.AppendText($"{player1Data[0]} wins initiative!\n");
                    return 1; // Player 1 starts
                }
                else if (player2Roll > player1Roll)
                {
                    txtBattleLog.AppendText($"{player2Data[0]} wins initiative!\n");
                    return 2; // Player 2 starts
                }
                else
                {
                    txtBattleLog.AppendText("Tie! Rolling again...\n");
                }
            } while (player1Roll == player2Roll);

            return 0;
        }

        private void frmPlayerTurn_Load(object sender, EventArgs e)
        {
            MusicManager.PlayBackgroundMusic("Assets/battle_theme.wav");

            // Determine who starts the game using initiative system
            int startingPlayer = takeInitiative();
            isPlayer1Turn = (startingPlayer == 1);

            // Update UI for the starting player
            UpdateUIForCurrentPlayer();
        }

        // Method to update UI elements based on whose turn it is
        private void UpdateUIForCurrentPlayer()
        {
            // First check if current player's dragon is dead (Q.3.1)
            if ((isPlayer1Turn && player1Values[0] <= 0) || (!isPlayer1Turn && player2Values[0] <= 0))
            {
                if (isPlayer1Turn)
                {
                    grpPlayerTurn.Text = $"{player1Data[0]}'s Turn";
                    lblPlayerHP.Text = $"HP: 0";
                    lblOpponentDragonName.Text = $"{player2Data[1]}, the {player2Data[2]} Dragon";
                    lblOpponentHP.Text = $"HP: {player2Values[0]}";

                    txtBattleLog.AppendText($"\n{player1Data[0]}'s Turn:\n");
                    txtBattleLog.AppendText($"{player1Data[1]} is unable to continue. {player2Data[1]} is the victor!\n");
                }
                else
                {
                    grpPlayerTurn.Text = $"{player2Data[0]}'s Turn";
                    lblPlayerHP.Text = $"HP: 0";
                    lblOpponentDragonName.Text = $"{player1Data[1]}, the {player1Data[2]} Dragon";
                    lblOpponentHP.Text = $"HP: {player1Values[0]}";

                    txtBattleLog.AppendText($"\n{player2Data[0]}'s Turn:\n");
                    txtBattleLog.AppendText($"{player2Data[1]} is unable to continue. {player1Data[1]} is the victor!\n");
                }

                DisableActions();
                return;
            }

            // Handle resting state - show rest button if dragon needs to rest
            if ((isPlayer1Turn && player1NeedsRest) || (!isPlayer1Turn && player2NeedsRest))
            {
                isRestingPhase = true;
                btnAttack.Visible = false;
                btnSpecialAttack.Visible = false;
                btnBlock.Visible = false;
                btnRest.Visible = true;
                btnRest.Enabled = true;
                btnRest.Text = "Rest";
            }
            else
            {
                isRestingPhase = false;
                btnAttack.Visible = true;
                btnSpecialAttack.Visible = true;
                btnBlock.Visible = true;
                btnRest.Visible = false;
            }

            if (isPlayer1Turn)
            {
                // Player 1's turn - update UI elements
                grpPlayerTurn.Text = $"{player1Data[0]}'s Turn";
                lblPlayerHP.Text = $"HP: {player1Values[0]}";

                // Set opponent (Player 2) info
                lblOpponentDragonName.Text = $"{player2Data[1]}, the {player2Data[2]} Dragon";
                lblOpponentHP.Text = $"HP: {player2Values[0]}";

                // Update action buttons with player 1's values
                btnAttack.Text = $"Attack ({player1Values[1]} damage)";
                btnSpecialAttack.Text = $"Special Attack ({player1Values[2]} damage)";
                btnBlock.Text = $"Block ({player1Values[3]} reduction)";

                // Highlight current player's panel
                grpPlayerTurn.BackColor = Color.LightCyan;
                grpOpponent.BackColor = SystemColors.Control;
            }
            else
            {
                // Player 2's turn - update UI elements
                grpPlayerTurn.Text = $"{player2Data[0]}'s Turn";
                lblPlayerHP.Text = $"HP: {player2Values[0]}";

                // Set opponent (Player 1) info
                lblOpponentDragonName.Text = $"{player1Data[1]}, the {player1Data[2]} Dragon";
                lblOpponentHP.Text = $"HP: {player1Values[0]}";

                // Update action buttons with player 2's values
                btnAttack.Text = $"Attack ({player2Values[1]} damage)";
                btnSpecialAttack.Text = $"Special Attack ({player2Values[2]} damage)";
                btnBlock.Text = $"Block ({player2Values[3]} reduction)";

                // Highlight current player's panel
                grpPlayerTurn.BackColor = Color.LightSkyBlue;
                grpOpponent.BackColor = SystemColors.Control;
            }

            txtBattleLog.SelectionStart = txtBattleLog.Text.Length;
            txtBattleLog.ScrollToCaret();
        }

        private void frmPlayerTurn_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicManager.StopBackgroundMusic();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            // Reset block status at start of each action
            opponentBlockedLastAttack = false;

            if (isPlayer1Turn)
            {
                // Check if opponent (Player 2) is blocking
                if (player2IsBlocking)
                {
                    int damageAfterBlock = Math.Max(0, player1Values[1] - player2Values[3]);
                    player2Values[0] -= damageAfterBlock;
                    txtBattleLog.AppendText($"{player2Data[1]} blocked! {player1Data[1]}'s attack was reduced to {damageAfterBlock} damage\n");
                    opponentBlockedLastAttack = true;
                    player2IsBlocking = false; // Reset the block after it's used
                }
                else
                {
                    player2Values[0] -= player1Values[1];
                    txtBattleLog.AppendText($"{player1Data[1]} attacks {player2Data[1]}! {player2Data[1]} takes {player1Values[1]} damage\n");
                }
            }
            else
            {
                // Check if opponent (Player 1) is blocking
                if (player1IsBlocking)
                {
                    int damageAfterBlock = Math.Max(0, player2Values[1] - player1Values[3]);
                    player1Values[0] -= damageAfterBlock;
                    txtBattleLog.AppendText($"{player1Data[1]} blocked! {player2Data[1]}'s attack was reduced to {damageAfterBlock} damage\n");
                    opponentBlockedLastAttack = true;
                    player1IsBlocking = false; // Reset the block after it's used
                }
                else
                {
                    player1Values[0] -= player2Values[1];
                    txtBattleLog.AppendText($"{player2Data[1]} attacks {player1Data[1]}! {player1Data[1]} takes {player2Values[1]} damage\n");
                }
            }

            // Switch player turns if the attack wasn't blocked
            if (!opponentBlockedLastAttack)
            {
                SwitchPlayerTurn();
            }
            else
            {
                UpdateUIForCurrentPlayer();
            }

            UpdateAfterAction();
        }

        private void btnSpecialAttack_Click(object sender, EventArgs e)
        {
            opponentBlockedLastAttack = false;

            if (isPlayer1Turn)
            {
                if (player2IsBlocking)
                {
                    int damageAfterBlock = Math.Max(0, player1Values[2] - player2Values[3]);
                    player2Values[0] -= damageAfterBlock;
                    txtBattleLog.AppendText($"{player2Data[1]} blocked! {player1Data[1]}'s special attack was reduced to {damageAfterBlock} damage\n");
                    opponentBlockedLastAttack = true;
                    player2IsBlocking = false;
                }
                else
                {
                    player2Values[0] -= player1Values[2];
                    txtBattleLog.AppendText($"{player1Data[1]} uses special attack on {player2Data[1]}! {player2Data[1]} takes {player1Values[2]} damage\n");
                }

                // Player 1 needs to rest next turn after using special attack
                player1NeedsRest = true;
                txtBattleLog.AppendText($"{player1Data[1]} is exhausted and will need to rest next turn!\n"); // Fixed: Now shows current dragon's name
            }
            else
            {
                if (player1IsBlocking)
                {
                    int damageAfterBlock = Math.Max(0, player2Values[2] - player1Values[3]);
                    player1Values[0] -= damageAfterBlock;
                    txtBattleLog.AppendText($"{player1Data[1]} blocked! {player2Data[1]}'s special attack was reduced to {damageAfterBlock} damage\n");
                    opponentBlockedLastAttack = true;
                    player1IsBlocking = false;
                }
                else
                {
                    player1Values[0] -= player2Values[2];
                    txtBattleLog.AppendText($"{player2Data[1]} uses special attack on {player1Data[1]}! {player1Data[1]} takes {player2Values[2]} damage\n");
                }

                // Player 2 needs to rest next turn after using special attack
                player2NeedsRest = true;
                txtBattleLog.AppendText($"{player2Data[1]} is exhausted and will need to rest next turn!\n"); // Fixed: Now shows current dragon's name
            }

            if (!opponentBlockedLastAttack)
            {
                SwitchPlayerTurn();
            }
            else
            {
                UpdateUIForCurrentPlayer();
            }

            UpdateAfterAction();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn)
            {
                player1IsBlocking = true;
                txtBattleLog.AppendText($"{player1Data[1]} prepares to block next attack\n");
            }
            else
            {
                player2IsBlocking = true;
                txtBattleLog.AppendText($"{player2Data[1]} prepares to block next attack\n");
            }

            SwitchPlayerTurn();
            UpdateAfterAction();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            // Call the Rest method with current player status
            Rest(isPlayer1Turn);
        }

        private void UpdateAfterAction()
        {
            // Check for game over
            if (CheckGameOver()) return;

            // Update UI
            UpdateUIForCurrentPlayer();
        }

        private bool CheckGameOver()
        {
            if (player1Values[0] <= 0)
            {
                txtBattleLog.AppendText($"\n{player2Data[0]} wins! {player1Data[1]} has been defeated!\n");
                DisableActions();
                return true;
            }
            else if (player2Values[0] <= 0)
            {
                txtBattleLog.AppendText($"\n{player1Data[0]} wins! {player2Data[1]} has been defeated!\n");
                DisableActions();
                return true;
            }
            return false;
        }

        private void DisableActions()
        {
            btnAttack.Enabled = false;
            btnSpecialAttack.Enabled = false;
            btnBlock.Enabled = false;
            btnRest.Enabled = false;
        }

        private void SwitchPlayerTurn()
        {
            // Only increment turn count if not in resting phase
            if (!isRestingPhase)
            {
                turnCount++;
            }

            // Normal turn switching when not resting
            if (!isRestingPhase)
            {
                // Check if we need to roll initiative (after every 2 turns)
                if (turnCount % 2 == 0)
                {
                    int startingPlayer = takeInitiative();
                    isPlayer1Turn = (startingPlayer == 1);
                }
                else
                {
                    // Toggle the turn flag normally
                    isPlayer1Turn = !isPlayer1Turn;
                }
            }

            // Reset blocking status for the new turn player
            if (isPlayer1Turn)
                player1IsBlocking = false;
            else
                player2IsBlocking = false;

            // Add turn notification to battle log
            string currentPlayer = isPlayer1Turn ? player1Data[0] : player2Data[0];
            txtBattleLog.AppendText($"\n{currentPlayer}'s Turn:\n");

            // Update UI
            UpdateUIForCurrentPlayer();
        }
    }
}