using System;
using System.Drawing;

namespace RubiksCubeGame.RubiksCubeFiles
{
    public class Colors
    {
        public static readonly Colors DevsScheme = new Colors
            (Color.Green, Color.Blue, Color.Red, Color.Orange, Color.White, Color.Yellow);

        public Color UpColor { get; }

        public Color DownColor { get; }

        public Color LeftColor { get; }

        public Color RightColor { get; }

        public Color FrontColor { get; }

        public Color BackColor { get; }

        public Color[] All =>
            new[] { UpColor, DownColor, RightColor, LeftColor, FrontColor, BackColor };

        public Colors(Color frontColor, Color backColor, Color rightColor,
            Color leftColor, Color upColor, Color downColor)
        {
            FrontColor = frontColor;
            BackColor = backColor;
            RightColor = rightColor;
            LeftColor = leftColor;
            UpColor = upColor;
            DownColor = downColor;
        }
    }
}
