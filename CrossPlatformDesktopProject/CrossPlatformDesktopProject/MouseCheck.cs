using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

//checks any mouse inputs and returns updated iSprite
namespace CrossPlatformDesktopProject
{
    class MouseCheck : checkInput
    {
        //initialize local variables
        private MouseState mouseLocation;
        public Texture2D link { get; set; }
        public ISprite checkMouse(ISprite iSprite, Texture2D link)
        {

            //check if any inputs have been made and if so update iSprite
            mouseLocation = Mouse.GetState();

            if (mouseLocation.X < 400 && mouseLocation.Y < 240 && mouseLocation.LeftButton == ButtonState.Pressed)
            {
                iSprite = new FixedNonanimated(link);
            }
            else if (mouseLocation.X > 400 && mouseLocation.Y < 240 && mouseLocation.LeftButton == ButtonState.Pressed)
            {
                iSprite = new FixedAnimated(link, 20, 20);
            }
            else if (mouseLocation.X < 400 && mouseLocation.Y > 240 && mouseLocation.LeftButton == ButtonState.Pressed)
            {
                iSprite = new MovingNonanimated(link);
            }
            else if (mouseLocation.X > 400 && mouseLocation.Y > 240 && mouseLocation.LeftButton == ButtonState.Pressed)
            {
                iSprite = new MovingAnimated(link, 20, 20);
            }

            return iSprite;

        }

    }
}
