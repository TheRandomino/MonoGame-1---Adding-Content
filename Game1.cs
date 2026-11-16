using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_1___Adding_Content
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Rectangle window;
        Texture2D dinoTexture;
        Texture2D heathcliffTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 500);

            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            this.Window.Title = "Im a title!";
            _graphics.ApplyChanges();
            base.Initialize();
            
            


        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            dinoTexture = Content.Load<Texture2D>("dino");
            heathcliffTexture = Content.Load<Texture2D>("heathcliff_limbus (1)");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Goldenrod);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(dinoTexture, new Vector2(10, 10), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(100, 10), Color.Purple);
            _spriteBatch.Draw(heathcliffTexture, new Vector2(300, 10), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
