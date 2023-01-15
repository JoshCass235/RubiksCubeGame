using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RubiksCubeGame.Forms;
using RubiksCubeGame.RubiksCubeFiles;

namespace RubiksCubeGame
{
    public partial class MainForm : Form
    {
        private readonly RubiksCube rubiksCube;

        private IEnumerable<TwoDCubeDisplay> CubeDisplays =>
            tableLayoutPanel.Controls.OfType<TwoDCubeDisplay>();

        private void UpdateDisplayedCube()
        {
            foreach (var display in CubeDisplays)
                display.RubiksCube = rubiksCube;
        }

        /// <summary>
        /// Initialize Forms component
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ResizeRedraw = true;
            rubiksCube = RubiksCube.Create(Colors.DevsScheme);
            UpdateDisplayedCube();
        }

        private static DialogResult ShowQuestionPrompt(string message)
        {
            return MessageBox.Show(message, Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        /// <summary>
        /// Check Undo with dialog box
        /// </summary>
        private void UndoChanges_Click(object sender, EventArgs e)
        {
            if (ShowQuestionPrompt("Are you sure you want to undo changes?") == DialogResult.Yes)
            {
                rubiksCube.Restore();
                tableLayoutPanel.Invalidate(true);
            }
        }
        /// <summary>
        /// Text Box key down event
        /// </summary>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            //Allow multiple moves with split
            string[] splitted = textBoxCommand.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var moveList = new List<Moves>();

            foreach (string str in splitted)
            {
                try
                {
                    moveList.Add(new Moves(str));
                }
                catch (ArgumentException)
                {
                    return;
                }
            }

            foreach (var move in moveList)
            {
                rubiksCube.MakeMove(move);
            }

            e.SuppressKeyPress = true;
            textBoxCommand.Clear();
            tableLayoutPanel.Invalidate();
        }
    }

}
