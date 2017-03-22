using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using SpaceShootEmUp.Entity;

namespace SpaceShootEmUp.Textures
{
    class TextureContainer
    {
        private Texture2D[][] m_ArrayOfArrayOfTexture;

        public TextureContainer(int NumberOfTexturesUser)
        {
            m_ArrayOfArrayOfTexture = new Texture2D[NumberOfTexturesUser][];
        }

        public Texture2D[][] ListOfArrayOfTexture
        {
            get { return m_ArrayOfArrayOfTexture; }
            set { m_ArrayOfArrayOfTexture = value; }
        }

        public Texture2D[] this[int EntityType]
        {
            get { return m_ArrayOfArrayOfTexture[EntityType]; }
            set
            {
                /* set the specified index to value here */
            }
        }

    }
}
