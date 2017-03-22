using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SpaceShootEmUp.Entity
{
    class Asteroid : BaseEntity
    {
        
        public Asteroid(Vector2 Position, Transition EntityTransition, EntityType Type = EntityType.Asteroid, Rectangle? Borders = null, Vector2 Velocity = default(Vector2)) : base(Position, Type, EntityTransition, Borders, Velocity)
        {
            
        }
        
        
    }
}
