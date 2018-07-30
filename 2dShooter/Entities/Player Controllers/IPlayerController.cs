using Microsoft.Xna.Framework;

namespace BattleRoyal2d.Entities
{
    public interface IPlayerController
    {
        Vector2 GetStartingPosition();

        Vector2 GetVelocity();

        float GetRotation();
    }
}