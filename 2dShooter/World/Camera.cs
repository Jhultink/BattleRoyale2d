using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale2d.World
{
    public class Camera
    {
        public Matrix Transform { get; private set; }


        private Viewport viewport;
        public float Zoom = 1f;

        public Rectangle Bounds { get { return viewport.Bounds; } }

        public Vector2 Center;

        public Vector2 Position { get { return Center - new Vector2(Bounds.Width / 2, Bounds.Height / 2); } }

        public Camera(Viewport newViewport)
        {
            viewport = newViewport;
        }

        public void Update(Vector2 position)
        {
            if (position.X < viewport.Width / 2)
                Center.X = viewport.Width / 2;
            else if (position.X > Map.Width - (viewport.Width / 2))
                Center.X = Map.Width - (viewport.Width / 2);
            else
                Center.X = position.X;
            
            if (position.Y < viewport.Height / 2)
                Center.Y = viewport.Height / 2;
            else if (position.Y > Map.Height - (viewport.Height / 2))
                Center.Y = Map.Height - (viewport.Height / 2);
            else
                Center.Y = position.Y;

            Transform = Matrix.CreateTranslation(new Vector3(-Center.X + (viewport.Width / 2),
                                                             -Center.Y + (viewport.Height / 2), 1f)) * Matrix.CreateScale(Zoom);
        }

        public void UpdateScreenSize(int width, int height)
        {
            viewport.Width = width;
            viewport.Height = height;
        }
    }
}
