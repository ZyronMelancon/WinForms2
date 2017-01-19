using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms2
{
    public partial class Form1 : Form
    {
        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;
        private Party party1;
        private Party party2;
        private TurnMngr combat;

        public Form1()
        {
            InitializeComponent();
            player1 = new Player("Player 1");
            player2 = new Player("Player 2");
            player3 = new Player("Enemy 1");
            player4 = new Player("Enemy 2");
            party1 = new Party();
            party2 = new Party();
            combat = new TurnMngr();

            party1.AddPlayer(player1);
            party1.AddPlayer(player2);
            party2.AddPlayer(player3);
            party2.AddPlayer(player4);
            combat.AddParty(party1);
            combat.AddParty(party2);


            PlayerNameDisplay.Text = combat.CurrentParty.CurrentPlayer.Name;
            P1HPProg.Value = combat.CurrentParty.CurrentPlayer.Health;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            combat.CurrentParty.CurrentPlayer.Action = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            combat.CurrentParty.CurrentPlayer.Action = 2;
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            //Check if this is the last player of the last party. If so, execute all player's attacks.
            if (combat.Index == combat.parties.Count - 1 && combat.parties[combat.parties.Count - 1].Index == combat.parties[combat.parties.Count - 1].members.Count - 1)
                for (int i = 0; i < combat.parties.Count; i++)
                    for (int o = 0; o < combat.parties[i].members.Count; o++)
                    {
                        int p = i + 1;
                        if (i == combat.parties.Count - 1)
                            p = 0;

                        combat.parties[i].members[o].ExecuteAction(combat.parties[p].members[o]);
                        combat.parties[i].members[o].Action = 0;
                        combat.parties[i].members[o].AddAttack = 0;
                        combat.parties[i].members[o].AddDefense = 0;
                    }

            if (combat.CurrentParty.Index == combat.CurrentParty.members.Count - 1)
            {
                combat.CurrentParty.CurrentPlayer.EndTurn();
                combat.GoNext();
            }
            else
                combat.CurrentParty.CurrentPlayer.EndTurn();
            

            PlayerNameDisplay.Text = combat.CurrentParty.CurrentPlayer.Name;
            P1HPProg.Value = combat.CurrentParty.CurrentPlayer.Health;
        }
    }
}
