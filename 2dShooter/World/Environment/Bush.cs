using BattleRoyal2d.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale2d.World.Environment
{
    public class Bush : Entity
    {
        private static Random rand = new Random();

        public Bush(Vector2 position) : base(position, 60, 60)
        {
            this.Position = position;
        }

        public override void Load(ContentManager content)
        {
            this.texture = content.Load<Texture2D>("environment/bushes/bush" + (rand.Next(6) + 1));
        }

        public override void Update(GameTime gameTime)
        {
        }
    }
}
