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
    public class MovingAnimated : ISprite
    {
        //initialize local variables
        public Texture2D link { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int offset = 0;
        private int totalFrames;

        public MovingAnimated(Texture2D texture, int rows, int columns)
        {

            // set local variables
            link = texture;
            Columns = columns;
            currentFrame = 0;
            totalFrames = 20;
        }

        public void Update()
        {
            //calculates the current frame and offset for possition of the sprite
            offset = offset + 2;
            if(offset > 400)
            {
                offset = -420;
            }
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            // calculate the current sprite and where it will be placed within the game and draw said sprite
            int width = 36 / 2;
            int height = 20;
            int column = (currentFrame / 10) % Columns;

            //rectangles for the location of the sprite and the spriete image from the main texture 
            Rectangle sourceSprite = new Rectangle(34 + width * column, 10, width - 1, height);
            Rectangle destinationSprite = new Rectangle((int)location.X + offset, (int)location.Y, width * 2, height * 2);

            spriteBatch.Draw(link, destinationSprite, sourceSprite, Color.White);
        }
    }
}