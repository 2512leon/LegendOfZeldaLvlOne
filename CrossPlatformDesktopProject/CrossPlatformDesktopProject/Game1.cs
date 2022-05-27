using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace CrossPlatformDesktopProject
{
    /// <summary>
    /// A simple game to show the undserstanding of how to use sprites, aminations, and controller movment from the keyboard and mouse
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private ISprite iSprite;
        private IController iController;
        private MouseState mouseLocation;
        private SpriteFont font;
        private SpriteFont fontURL;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
        }

       

        protected override void Initialize()
        {

            base.Initialize();
        }

        /// <summary>
        /// load all content that will used for the game
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //create a 2d texture variable to store the sprite image field
            Texture2D link = Content.Load<Texture2D>("Link");
 
            font = Content.Load<SpriteFont>("Credits");
            fontURL = Content.Load<SpriteFont>("URL");

            //create the interfaces
            iController = new checkInput();
            iSprite = new FixedNonanimated(link);
            iController.LoadContent();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
        }

        /// <summary>
        /// Check if the user has any inputs and updata sprite data
        /// </summary>
        protected override void Update(GameTime gameTime)
        {
            //create a 2d texture variable to store the sprite image field
            Texture2D link = Content.Load<Texture2D>("Link");
            mouseLocation = Mouse.GetState();

            //if else statments for each of the possible operations and sets a value to button to draw the correct sprite
            if (Keyboard.GetState().IsKeyDown(Keys.D0) || mouseLocation.RightButton == ButtonState.Pressed)
            {
                Exit();
            }
            //update the current sprite by checking if any inputs have been made
            iSprite = iController.Update(iSprite, link);
            //update sprite
            iSprite.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// draw the required sprite that was determined by the user
        /// </summary>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);
            spriteBatch.Begin();

            //print draw the current sprite
            iSprite.Draw(spriteBatch, new Vector2(400, 200));
            //print sprits for the credits
            spriteBatch.DrawString(font, "Credits", new Vector2(10, 340), Color.Black);
            spriteBatch.DrawString(font, "Program Made By: Collin Libby", new Vector2(10, 370), Color.Black);
            spriteBatch.DrawString(font, "Sprites from:", new Vector2(10, 400), Color.Black);
            spriteBatch.DrawString(fontURL, "https://www.spriters-resource.com/nes/legendofzelda/sheet/8366/", new Vector2(192, 415), Color.Black);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
