using System.Drawing;

namespace RubiksCubeGame.Grid
{
    public class RenderGridStyling
    {
        public Color[,] Colors { get; set; }

        public float CellSpacingScale { get; set; }

        public int RoundedRadius { get; set; }

        public RenderGridStyling(Color[,] colors, float cellSpacing, int roundedRadius)
        {
            Colors = colors;
            CellSpacingScale = cellSpacing;
            RoundedRadius = roundedRadius;
        }
    }
}
