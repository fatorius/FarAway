// This class launches the game

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FarAway.src
{
    public class Main : Game{
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SpriteFont font;

        public Main(){
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize(){
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent(){
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            
            font = Content.Load<SpriteFont>("Fonts/BasicFont");
        }

        protected override void Update(GameTime gameTime){
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime){
            GraphicsDevice.Clear(Color.Wheat);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.DrawString(font, "Far Away", new Vector2(0, 0), Color.Black);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
