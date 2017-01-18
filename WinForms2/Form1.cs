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
        private Party party1;
        private Party party2;
        private TurnMngr combat;

        public Form1()
        {
            InitializeComponent();
            player1 = new Player();
            player2 = new Player();
            party1 = new Party();
            party2 = new Party();
            combat = new TurnMngr();

            player1.Name = "Player 1";
            player2.Name = "Player 2";

            party1.AddPlayer(player1);
            party2.AddPlayer(player2);
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
            combat.CurrentParty.CurrentPlayer.EndTurn();

            if (combat.Index == combat.parties.Count - 1)
                for (int i = 0; i < combat.parties.Count; i++)
                    for (int o = 0; o < combat.parties[i].members.Count; o++)
                    {
                        combat.parties[i].members[o].ExecuteAction(combat.parties[i % combat.parties.Count].members[combat.CurrentParty.Index]);
                        combat.parties[i].members[o].Action = 0;
                        combat.parties[i].members[o].AddAttack = 0;
                        combat.parties[i].members[o].AddDefense = 0;
                    }

            if (combat.CurrentParty.Index == combat.CurrentParty.members.Count-1)
                combat.GoNext();
            

            PlayerNameDisplay.Text = combat.CurrentParty.CurrentPlayer.Name;
            P1HPProg.Value = combat.CurrentParty.CurrentPlayer.Health;
        }
    }
}
