using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleRoyale2d.Items.Weapons;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleRoyal2d.Entities
{
    public class PlayerEntity : Entity
    {
        IPlayerController controller;

        public Weapon Weapon { get; set; }

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
            this.Position += controller.GetVelocity();
            this.Weapon.Position = this.Bounds.Center.ToVector2();
            this.Weapon.Rotation = controller.GetRotation();
            this.Weapon?.Update(gameTime);
        }

        public override void Draw(SpriteBatch batch)
        {
            // Draw player
            base.Draw(batch);

            // Draw weapon
            this.Weapon?.Draw(batch);
        }
    }
}
