using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyal2d.Entities
{
    public abstract class Entity
    {
        public Entity(Vector2 position, int width, int height)
        {
            this.Height = height;
            this.Width = width;
            this.Position = position;
        }

        protected Texture2D texture;

        public int Width { get; set; }

        public int Height { get; set; }

        public Vector2 Position { get; protected set; }

        public Rectangle Bounds { get { return new Rectangle((int)Position.X, (int)Position.Y, Width, Height); } }

        public abstract void Load(ContentManager content);

        public abstract void Update(GameTime gameTime);

        public virtual void Draw(SpriteBatch batch)
        {
            batch.Draw(texture, Bounds, Color.White);
        }
    }
}
