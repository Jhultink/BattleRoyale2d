using BattleRoyal2d.Entities;
using BattleRoyal2d.Entities.Player_Controllers;
using BattleRoyale2d.Items.Weapons;
using BattleRoyale2d.World;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BattleRoyal2d
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class ShooterGame : Game
    {
        public static PlayerEntity Player;
        public static Camera Camera;
        public static Map Map;

        public Weapon weapon;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public ShooterGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            Player = new PlayerEntity(new MainPlayerController());
            weapon = new AR();

            Player.Weapon = weapon;

            Camera = new Camera(GraphicsDevice.Viewport);
            Map = new Map();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Player.Load(Content);
            Map.Load(Content);
            weapon.Load(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            Player.Update(gameTime);
            Camera.Update(Player.Position);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera.Transform);

            GraphicsDevice.Clear(Color.DarkOliveGreen);


            Player.Draw(spriteBatch);

            Map.Draw(spriteBatch);


            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
