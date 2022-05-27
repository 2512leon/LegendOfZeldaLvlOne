using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace CrossPlatformDesktopProject
{
    public class MovingNonanimated : ISprite
    {
        //initialize local variables
        public Texture2D link { get; set; }
        private int offset = 0;
        public MovingNonanimated(Texture2D texture)
        {
            //set local variables
            link = texture;

        }
        public void Update()
        {

            //calculates the offset for possition of sprite
            offset = offset - 2; 
            if(offset < -270)
            {

                offset = 280;
                
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {

            int width = link.Width / 20;
            int height = link.Height / 20 + 5;

            //rectangles for the location of the sprite and the spriete image from the main texture 

            Rectangle sourceRectangle = new Rectangle(width, 10, width - 2, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y + offset, width * 2, height * 2);

            spriteBatch.Draw(link, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
