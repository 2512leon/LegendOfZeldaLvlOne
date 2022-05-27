using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

//interface to check inputs and updata iSprite
namespace CrossPlatformDesktopProject
{
    public class checkInput : IController
    { 
        
        //initialize local variables
        private KeyboardCheck keyboardChecker;
        private MouseCheck mouseChecker;
        public Texture2D link { get; set; }

        
        public void LoadContent()
        {
            //load checkers
            keyboardChecker = new KeyboardCheck();
            mouseChecker = new MouseCheck();
        }

        public ISprite Update(ISprite iSprite, Texture2D link)
        {

            //check if any inputs have been made
            iSprite = keyboardChecker.checkKeyboard(iSprite, link);
            iSprite = mouseChecker.checkMouse(iSprite, link);
            return iSprite;
        }

        
    }
    
}
