using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms2
{
    class Player
    {
        //Parameters
        private string m_name;
        private int m_level;
        private int m_experience;
        private int m_expcap;
        private int m_health;
        private int m_atkpwr;
        private int m_defpwr;
        private int m_action;
        private int m_addatk;
        private int m_adddef;

        public string Name { get { return m_name; } set { m_name = value; } }
        public int ExpCap { get { return m_expcap; } }
        public int Level { get { return m_level; } set { m_level = value; } }
        public int Experience { get { return m_experience; } set { m_experience = value; } }
        public int Health { get { return m_health; } set { m_health = value; } }
        public int AtkPwr { get { return m_atkpwr; } set { m_atkpwr = value; } }
        public int DefPwr { get { return m_defpwr; } set { m_defpwr = value; } }
        public int Action {  get { return m_action;  } set { m_action = value; } }
        public int AddAttack { get { return m_addatk; } set { m_addatk = value; } }
        public int AddDefense { get { return m_adddef; } set { m_adddef = value; } }

        //Actions
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

        public void ExecuteAction(Player b)
        {
            if (Action == 1)
                if (b.Health > 0)
                    if ((b.DefPwr + b.AddDefense) < AtkPwr)
                        b.Health -= AtkPwr - (b.DefPwr + b.AddDefense);
            if (Action == 2)
                AddDefense = DefPwr;
        }


        //Delegate
        public delegate void OnEndTurn();

        public OnEndTurn onEndTurn;

        public void EndTurn()
        {
            if (onEndTurn != null)
                onEndTurn.Invoke();
        }

        //Initialization stuff
        public Player()
        {
            m_name = "Player";
            m_level = 1;
            m_experience = 0;
            m_expcap = 1;
            m_health = 100;
            m_atkpwr = 20;
            m_defpwr = 10;
            m_action = 0;
        }

        public Player(string n)
        {
            Name = n;
            Level = 1;
            Experience = 0;
            m_expcap = 1;
            Health = 100;
            AtkPwr = 20;
            DefPwr = 10;
            Action = 0;
        }
        public Player(string n, int h, int a, int d)
        {
            Name = n;
            Level = 1;
            Health = h;
            AtkPwr = a;
            DefPwr = d;
            Action = 0;
        }

    }
}
