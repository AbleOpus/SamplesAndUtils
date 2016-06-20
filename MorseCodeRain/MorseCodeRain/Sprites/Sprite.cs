using System.Drawing;

namespace MorseCodeRain.Sprites
{
    abstract class Sprite
    {
        /// <summary>
        /// Override to implement logic to draw this sprite.
        /// </summary>
        public abstract void Draw(Graphics graphics, Size canvasSize, decimal frameLength);

        /// <summary>
        /// To adjust the scaling values of the sprite.
        /// </summary>
        public virtual void AdjustScale(Size canvasSize) { }
    }
}
