using BattleRoyal2d.Entities;
using BattleRoyale2d.World.Environment;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale2d.World
{
    public class Map
    {
        private List<Entity> entities = new List<Entity>();

        public const int Width = 5000;

        public const int Height = 5000;

        public Map(int seed = 0)
        {
            Random random = new Random(seed);
            int bushesCnt = 100;

            for (int i = 0; i < bushesCnt; i++)
            {
                int x = random.Next(Width);
                int y = random.Next(Height);
                entities.Add(new Bush(new Vector2(x, y)));
            }
        }

        public void Load(ContentManager content)
        {
            foreach (Entity entity in entities)
            {
                entity.Load(content);
            }
        }

        public void Draw(SpriteBatch batch)
        {
            foreach (Entity entity in entities)
            {
                entity.Draw(batch);
            }
        }
    }
}
