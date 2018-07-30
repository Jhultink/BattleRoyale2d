using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleRoyale2d.World;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BattleRoyal2d.Entities.Player_Controllers
{
    public class MainPlayerController : IPlayerController
    {
        private Vector2 position = new Vector2(0, 0);
        private float maxSpeed = 5.0f;

        public float GetRotation()
        {
            var mouse = Mouse.GetState();
            var x = mouse.Position;

            var angVec = ShooterGame..Center - mouse.Position.ToVector2();
            angVec.Normalize();

            return (float)Math.Atan2(angVec.X, -angVec.Y);
        }

        public Vector2 GetStartingPosition()
        {
            return position;
        }

        public Vector2 GetPosition()
        {
            var vel = new Vector2(0, 0);

            var keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.A))
                vel.X -= maxSpeed;
            if (keyboard.IsKeyDown(Keys.D))
                vel.X += maxSpeed;
            if (keyboard.IsKeyDown(Keys.W))
                vel.Y -= maxSpeed;
            if (keyboard.IsKeyDown(Keys.S))
                vel.Y += maxSpeed;

            return vel;
        }
    }
}
