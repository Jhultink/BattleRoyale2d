using BattleRoyal2d.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale2d.Items.Weapons
{
    public abstract class Weapon : Entity
    {
        public float Rotation { get; set; }

        public Weapon() : base(new Vector2(0, 0), 20, 50)
        {
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.Draw(texture, Bounds, null, Color.White, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
        }
    }
}
