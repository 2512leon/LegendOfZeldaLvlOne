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
    public class FixedAnimated : ISprite
    {
        //initialize local variable
        private FixedAnimated fixedAnimated;
        public Texture2D link { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;


        public FixedAnimated(Texture2D texture, int rows, int columns)
        {
            //set local variable
            link = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = 20;
        }

        public void Update()
        {
            //calculates the current frame of the sprite
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            // calculate the current sprite and where it will be placed within the game and draw said sprite
            int width = link.Width / Columns;
            int height = link.Height / Rows + 5;
            int row = (int)(((float)currentFrame/10) / (float)Columns);
            int column = (currentFrame/10) % Columns;

            //rectangles for the location of the sprite and the spriete image from the main texture 
            Rectangle sourceRectangle = new Rectangle(width * column, height * row + 10, width - 2, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 2, height * 2);

            spriteBatch.Draw(link, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}

