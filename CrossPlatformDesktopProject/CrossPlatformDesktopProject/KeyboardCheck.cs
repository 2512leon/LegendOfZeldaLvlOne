using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

//checks any keyboard inputs and returns updated iSprite
namespace CrossPlatformDesktopProject
{
    class KeyboardCheck : checkInput
    {
        //initialize local variables
        public Texture2D link { get; set; }
        public ISprite checkKeyboard(ISprite iSprite, Texture2D link)
        {

            //check if any inputs have been made if so update iSprite
            if (Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                iSprite = new FixedNonanimated(link);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D2))
            {
                iSprite = new FixedAnimated(link, 20, 20);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D3))
            {
                iSprite = new MovingNonanimated(link);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D4))
            {
                iSprite = new MovingAnimated(link, 20, 20);
            }

            return iSprite;
        }
    }
}
