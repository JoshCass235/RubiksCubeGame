using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RubiksCubeGame.Grid;
using RubiksCubeGame.RubiksCubeFiles;

namespace RubiksCubeGame.Forms
{
    class TwoDCubeDisplay : Control
    {
        
        private CubeSide face = CubeSide.None;
        public CubeSide Face
        {
            get { return face; }
            set
            {
                face = value;
                Invalidate();
            }
        }

        private RubiksCube rubiksCube;
        public RubiksCube RubiksCube
        {
            get { return rubiksCube; }
            set
            {
                rubiksCube = value;
                Invalidate();
            }
        }

        private Color[,] FaceColors
        {
            get
            {
                if (rubiksCube == null) return null;

                switch (Face)
                {
                    case CubeSide.Front: return RubiksCube.FrontColors;
                    case CubeSide.Back: return RubiksCube.BackColors;
                    case CubeSide.Right: return RubiksCube.RightColors;
                    case CubeSide.Left: return RubiksCube.LeftColors;
                    case CubeSide.Up: return RubiksCube.UpColors;
                    case CubeSide.Down: return RubiksCube.DownColors;
                    default: return null;
                }
            }
        }

        private int roundedRadius = 5;
        public int RoundedRadius
        {
            get { return roundedRadius; }
            set
            {
                roundedRadius = value;
                Invalidate();
            }
        }

        private RenderGridStyling Style =>
    new RenderGridStyling(FaceColors, 0.05f, RoundedRadius);

        public TwoDCubeDisplay()
        {
            SetStyle(ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            RenderGrid.Draw(Style, e.Graphics, ClientSize, Enabled);
        }
    }
}
