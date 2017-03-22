using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShootEmUp.Entity
{
    class Transition
    {
        private double m_TransitionTime;
        private double m_TransitionStartTime;
        private int m_NumberOfTransitions;

        public Transition(double TransitionStartTime, int NumberOfTransitions = 1)
        {
            m_TransitionTime = TransitionTime;
            m_TransitionStartTime = TransitionStartTime;
            m_NumberOfTransitions = NumberOfTransitions;
        }

        public int CurrentTransition(double CurrentTime)
        {
            return (int)((CurrentTime - TransitionStartTime) / TransitionTime)%NumberOfTransitions;
        }

        public double TransitionTime
        {
            get { return m_TransitionTime; }
            set { m_TransitionTime = value; }
        }

        public double TransitionStartTime
        {
            get { return m_TransitionStartTime; }
            set { m_TransitionStartTime = value; }
        }

        public int NumberOfTransitions
        {
            get { return m_NumberOfTransitions; }
            set { m_NumberOfTransitions = value; }
        }
    }
}
