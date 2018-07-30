using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleRoyal2d.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleRoyale2d.Items.Weapons
{
    public class AR : Weapon
    {
        public override void Load(ContentManager content)
        {
            this.texture = content.Load<Texture2D>("weapons/gun");
        }
    }
}
