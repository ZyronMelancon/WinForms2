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

        private TurnMngr Combat;

        public Form1()
        {
            InitializeComponent();
            player1 = new Player();
            player2 = new Player();
            player3 = new Player();
            Combat = new TurnMngr();
            Combat.Party1.Add(player1);
            Combat.Party1.Add(player2);
            Combat.Party1.Add(player3);
            Combat.Party1[2].Health = 50;
            P1HPProg.Value = Combat.Party1[Combat.Turn].Health;
            P1ATK.Text = "ATK: " + Combat.Party1[Combat.Turn].AtkPwr;
            P1DEF.Text = "DEF: " + Combat.Party1[Combat.Turn].DefPwr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            Combat.Turn = Combat.Turn + 1;
            P1HPProg.Value = Combat.Party1[Combat.Turn].Health;
            P1ATK.Text = "ATK: " + Combat.Party1[Combat.Turn].AtkPwr;
            P1DEF.Text = "DEF: " + Combat.Party1[Combat.Turn].DefPwr;
        }
    }

    public class TurnMngr
    {
        public List<Player> Party1 = new List<Player>();
        public List<Player> Party2 = new List<Player>();
        private int m_turn;

        public int Turn { get { return m_turn; }  set { if (m_turn < 3 && value < 2) m_turn = value; else m_turn = 1; }  }

        public TurnMngr()
        {
            Turn = 1;
        }
    }
    public class Player
    {
        private int m_level;
        private int m_experience;
        private int m_expcap;
        private int m_health;
        private int m_atkpwr;
        private int m_defpwr;
        
        public int ExpUp()
        {
            m_experience++;
            return m_experience;
        }
        public int LevelUp()
        {
            if (m_experience >= m_expcap)
            {
                m_level++;
                m_atkpwr += 2;
                m_defpwr++;
                m_expcap++;
                m_experience = 0;
            }
            return m_level;
        }

        public int ExpCap { get { return m_expcap; } }
        public int Level { get { return m_level; } set { m_level = value; } }
        public int Experience { get { return m_experience; } set { m_experience = value; } }
        public int Health { get { return m_health; } set { m_health = value; } }
        public int AtkPwr { get { return m_atkpwr; } set { m_atkpwr = value; } }
        public int DefPwr { get { return m_defpwr; } set { m_defpwr = value; } }
        public Player()
        {
            m_level = 1;
            m_experience = 0;
            m_expcap = 1;
            m_health = 100;
            m_atkpwr = 20;
            m_defpwr = 10;
        } 
    }
}
