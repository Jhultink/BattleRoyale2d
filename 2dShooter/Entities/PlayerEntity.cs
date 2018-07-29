using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleRoyal2d.Entities
{
    public class PlayerEntity : Entity
    {
        IPlayerController controller;



        public PlayerEntity(IPlayerController controller) : base(controller.GetStartingPosition(), 50, 50)
        {
            this.controller = controller;
        }

        public override void Load(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("player");
        }

        public override void Update(GameTime gameTime)
        {
            Position += controller.GetVelocity();
        }
    }
}
