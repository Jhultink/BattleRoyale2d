using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace BattleRoyal2d.Entities.Player_Controllers
{
    public class MainPlayerController : IPlayerController
    {
        private float maxSpeed = 5.0f;

        public Vector2 GetStartingPosition()
        {
            return new Vector2(0, 0);
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
