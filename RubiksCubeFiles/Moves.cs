using System;

namespace RubiksCubeGame.RubiksCubeFiles
{
    public enum Rotation
    {
        /// <summary>
        /// Clockwise
        /// </summary>
        Cw,
        /// <summary>
        /// Anti-Clockwise
        /// </summary>
        Acw
    }

    public enum CubeSide
    {
        None,
        Front,
        Back,
        Right,
        Left,
        Up,
        Down
    }

    public enum AlgorithmMoves
    {
        L,
        La,
        R,
        Ra,
        D,
        Da,
        U,
        Ua,
        F,
        Fa,
        B,
        Ba
    }

    internal class Moves
    {
        /// <summary>
        /// Gets the cube side corresponding to the given move
        /// </summary>
        public CubeSide Side { get; }

        /// <summary>
        /// Gets the move rotation
        /// </summary>
        public Rotation Rotation { get; }

        public Moves(CubeSide side, Rotation rotation)
        {
            Side = side;
            Rotation = rotation;
        }

        /// <summary>
        /// All legal moves
        /// </summary>
        public Moves(string notation)
        {
            switch (notation.Trim().ToLower())
            {
                case "f":
                    Rotation = Rotation.Cw;
                    Side = CubeSide.Front;
                    break;

                case "fa":
                    Rotation = Rotation.Acw;
                    Side = CubeSide.Front;
                    break;

                case "b":
                    Rotation = Rotation.Cw;
                    Side = CubeSide.Back;
                    break;

                case "ba":
                    Rotation = Rotation.Acw;
                    Side = CubeSide.Back;
                    break;

                case "r":
                    Rotation = Rotation.Cw;
                    Side = CubeSide.Right;
                    break;

                case "ra":
                    Rotation = Rotation.Acw;
                    Side = CubeSide.Right;
                    break;

                case "l":
                    Rotation = Rotation.Cw;
                    Side = CubeSide.Left;
                    break;

                case "la":
                    Rotation = Rotation.Acw;
                    Side = CubeSide.Left;
                    break;

                case "u":
                    Rotation = Rotation.Cw;
                    Side = CubeSide.Up;
                    break;

                case "ua":
                    Rotation = Rotation.Acw;
                    Side = CubeSide.Up;
                    break;

                case "d":
                    Rotation = Rotation.Cw;
                    Side = CubeSide.Down;
                    break;

                case "da":
                    Rotation = Rotation.Acw;
                    Side = CubeSide.Down;
                    break;

                default:
                    throw new ArgumentException("Move submited is not a valid rotation", nameof(notation));
            }
        }
    }
}
