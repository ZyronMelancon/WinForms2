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
        private TurnMngr combat;

        public Form1()
        {
            InitializeComponent();
            player1 = new Player();
            player2 = new Player();
            combat = new TurnMngr();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EndTurn_Click(object sender, EventArgs e)
        {

        }
    }

    public class TurnMngr
    {
        private int m_turn;
        private int m_phase;

        public int Turn { get { return m_turn; } set { m_turn = value; } }

        public TurnMngr()
        {
            Turn = 1;
        }
    }

    public class Party
    {
        private int m_ID;

        public List<Player> members = new List<Player>();

        public void AddPlayer(Player p)
        {
            members.Add(p);
            p.onEndTurn += NextPlayer;
        }

        public void NextPlayer()
        {
            m_ID++;
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

        public delegate void OnEndTurn();

        public OnEndTurn onEndTurn;

        public void EndTurn()
        {
            if (onEndTurn != null)
                onEndTurn.Invoke();
        }
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

        public bool Attack(Player b)
        {
            if (b.Health > 0)
            {
                b.Health -= AtkPwr - b.DefPwr;
                return true;
            }
            else
                return false;
        }

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
