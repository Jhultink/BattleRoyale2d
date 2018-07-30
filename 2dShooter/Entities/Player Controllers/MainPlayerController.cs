using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var mouse = Mouse.GetState().Position;
            var camera = ShooterGame.Camera.Bounds.Center;

            var vector = (camera - mouse).ToVector2();

            float ang = (float)Math.Atan2(vector.X, -vector.Y);

            return ang;
        }

        public Vector2 GetStartingPosition()
        {
            return position;
        }

        public Vector2 GetVelocity()
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
