using System.Drawing;

namespace RubiksCubeGame.Grid
{

    internal static class RenderGrid
    {
        /// <summary>
        /// Set bound for rectangles
        /// </summary>
        private static RectangleF[,] GetAllCellBounds(RenderGridStyling style, Size drawRegion)
        {
            var rects = new RectangleF[style.Colors.GetLength(0), style.Colors.GetLength(1)];
            float cellDim = GetDimensions(style, drawRegion);
            float xOffset = (drawRegion.Width / 2f) - style.Colors.GetLength(0) * cellDim / 2;
            float yOffset = (drawRegion.Height / 2f) - style.Colors.GetLength(1) * cellDim / 2;

            for (int row = 0; row < style.Colors.GetLength(0); row++)
            {
                for (int clm = 0; clm < style.Colors.GetLength(1); clm++)
                {
                    float y = yOffset + cellDim * clm;
                    float x = xOffset + cellDim * row;
                    float dim = cellDim;
                    rects[row, clm] = new RectangleF(x, y, dim, dim);
                }
            }

            return rects;
        }

        /// <summary>
        /// Groups rectangles together
        /// </summary>
        private static RectangleF GroupRectangles(RectangleF[,] rects)
        {
            float lowestX = float.MaxValue;
            float lowestY = float.MaxValue;
            float greatestRight = 0;
            float greateastBottom = 0;

            foreach (RectangleF rect in rects)
            {
                if (rect.Right > greatestRight) greatestRight = rect.Right;
                if (rect.Bottom > greateastBottom) greateastBottom = rect.Bottom;
                if (rect.X < lowestX) lowestX = rect.X;
                if (rect.Y < lowestY) lowestY = rect.Y;
            }

            return new RectangleF(lowestX, lowestY,
                greatestRight - lowestX, greateastBottom - lowestY);
        }

        private static float GetDimensions(RenderGridStyling style, Size drawRegion)
        {
            int gridWidth = style.Colors.GetLength(0);
            int gridHeight = style.Colors.GetLength(1);
            double widthRatio = (double)drawRegion.Width / gridWidth;
            double heightRatio = (double)drawRegion.Height / gridHeight;

            if (widthRatio > heightRatio)
            {
                return (float)drawRegion.Height / gridHeight;
            }

            return (float)drawRegion.Width / gridWidth;
        }

        private static RectangleF GetRectangleCollection(RenderGridStyling style, Size drawRegion)
        {
            var bounds = GetAllCellBounds(style, drawRegion);
            return GroupRectangles(bounds);
        }

        /// <summary>
        /// Draw grid from rectangles
        /// </summary>
        public static void Draw(RenderGridStyling style, Graphics graphics, Size drawRegion, bool enabled)
        {
            float cellDim = GetDimensions(style, drawRegion);
            float xOffset = (drawRegion.Width / 2f) - style.Colors.GetLength(0) * cellDim / 2;
            float yOffset = (drawRegion.Height / 2f) - style.Colors.GetLength(1) * cellDim / 2;
            float spacing = style.CellSpacingScale * cellDim;
            var master = GetRectangleCollection(style, drawRegion);
            var backPath = RectangleShape.Create(master, style.RoundedRadius);
            graphics.FillPath(enabled ? Brushes.Black : Brushes.DimGray, backPath);

            for (int row = 0; row < style.Colors.GetLength(0); row++)
            {
                for (int clm = 0; clm < style.Colors.GetLength(1); clm++)
                {
                    float dim = cellDim - spacing * 2;
                    var brush = new SolidBrush(style.Colors[clm, row]);
                    float x = (xOffset + cellDim * row) + spacing;
                    float y = (yOffset + cellDim * clm) + spacing;
                    var path = RectangleShape.Create(x, y, dim, dim, style.RoundedRadius);
                    graphics.FillPath(brush, path);
                    brush.Dispose();
                }
            }
        }
    }
}
