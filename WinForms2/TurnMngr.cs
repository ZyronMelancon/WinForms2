using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms2
{
    class TurnMngr
    {
        //Parameters
        private int m_index;
        public Party CurrentParty { get { return parties[m_index]; } }
        public int Index { get { return m_index; } set { m_index = value; } }

        //Party management
        public List<Party> parties = new List<Party>();
        public void AddParty(Party p)
        {
            parties.Add(p);
            p.onEndTurn += GoNext;
        }
        public void GoNext()
        {
            if (m_index < parties.Count() - 1)
                m_index++;
            else
                m_index = 0;
        }

        public int NextParty()
        {
            if (m_index < parties.Count() - 1)
                return m_index + 1;
            else
                return 0;
        }

        //Intialize
        public TurnMngr()
        {
            m_index = 0;
        }
    }
}
