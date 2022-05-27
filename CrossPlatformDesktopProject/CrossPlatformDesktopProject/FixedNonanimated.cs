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
    public class FixedNonanimated : ISprite
    {
        //initialize local variable
        public Texture2D link { get; set; }
        public FixedNonanimated(Texture2D texture)
        {
            //set local variable
            link = texture;
            
        }

        public void Update()
        {



        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            // calculate the current sprite and draw said sprite
            int width = link.Width / 20;
            int height = link.Height / 20 + 5;

            //rectangles for the location of the sprite and the spriete image from the main texture 
            Rectangle sourceRectangle = new Rectangle(width , 10, width - 2, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 2, height * 2);

            spriteBatch.Draw(link, destinationRectangle, sourceRectangle, Color.White);
        }
        }

    }

