using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms2
{
    class Party
    {
        //Parameters
        private string m_name;
        private int m_index;
        public Player CurrentPlayer { get { return members[m_index]; } }
        public int Index { get { return m_index; } set { m_index = value; } }
        public string Name { get { return m_name; } set { m_name = value; } }

        //Player management
        public List<Player> members = new List<Player>();
        public void AddPlayer(Player p)
        {
            members.Add(p);
            p.onEndTurn += GoNext;
        }
        public void GoNext()
        {
            if (m_index < members.Count-1)
                m_index++;
            else
                m_index = 0;
        }

        public int NextPlayer()
        {
            if (m_index < members.Count - 1)
                return m_index + 1;
            else
                return 0;
        }


        //Delegate stuff
        public delegate void OnEndTurn();

        public OnEndTurn onEndTurn;

        public void EndTurn()
        {
            if (onEndTurn != null)
                onEndTurn.Invoke();
        }

        //Initialization stuff
        public Party()
        {
            m_name = "Party";
            m_index = 0;
        }
    }
}
