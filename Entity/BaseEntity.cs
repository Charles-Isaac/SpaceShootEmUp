using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SpaceShootEmUp.Entity
{
    // Entity without a texture must appear after all Entity using a texture
    /// <summary>
    /// Enum every types of entity
    /// </summary>
    public enum EntityType
    {
        Player = 0,
        Asteroid = 1,
        Interceptor = 2,
        StealthFighter = 3,
        MissileShip = 4
    }
    class BaseEntity
    {
        private Vector2 m_Position;
        private Vector2 m_OldPosition;
        private Vector2 m_Velocity;
        private Rectangle? m_Borders;
        private EntityType m_Type;
        private Transition m_Transition;

        public BaseEntity(Vector2 Position, EntityType Type, Transition EntityTransition, Rectangle? Borders = null, Vector2 Velocity = default(Vector2))
        {
            m_OldPosition = m_Position = Position;
            m_Type = Type;
            m_Velocity = Velocity;
            m_Borders = Borders;
            m_Transition = EntityTransition;
        }

        public virtual bool Update(double DeltaTime)
        {
            m_Position += m_Velocity*(float)DeltaTime;
            return m_Borders?.Contains(m_Position) ?? false;
        }

        public Vector2 Position
        {
            get { return m_Position; }
            set { m_Position = value; }
        }

        public Vector2 OldPosition
        {
            get { return m_OldPosition; }
            set { m_OldPosition = value; }
        }

        public Vector2 Velocity
        {
            get { return m_Velocity; }
            set { m_Velocity = value; }
        }

        public EntityType Type
        {
            get { return m_Type; }
            set { m_Type = value; }
        }

        public Rectangle? Borders
        {
            get { return m_Borders; }
            set { m_Borders = value; }
        }

        public Transition Transition
        {
            get { return m_Transition; }
            set { m_Transition = value; }
        }
    }
}
