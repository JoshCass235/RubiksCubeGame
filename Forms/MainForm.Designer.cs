
using RubiksCubeGame.Forms;

namespace RubiksCubeGame
{
    partial class MainForm
    {
        #region Windows Form Designer generated code
        private void InitializeComponent() //TODO: Look at all sizing
        {
            this.label = new System.Windows.Forms.Label();
            this.buttonUndoChanges = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.cubeUp = new RubiksCubeGame.Forms.TwoDCubeDisplay();
            this.cubeBack = new RubiksCubeGame.Forms.TwoDCubeDisplay();
            this.cubeFront = new RubiksCubeGame.Forms.TwoDCubeDisplay();
            this.cubeDown = new RubiksCubeGame.Forms.TwoDCubeDisplay();
            this.cubeRight = new RubiksCubeGame.Forms.TwoDCubeDisplay();
            this.cubeLeft = new RubiksCubeGame.Forms.TwoDCubeDisplay();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 15);
            this.label.TabIndex = 18;
            this.label.Text = "Enter Move:";
            // 
            // buttonUndoChanges
            // 
            this.buttonUndoChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUndoChanges.Location = new System.Drawing.Point(472, 11);
            this.buttonUndoChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUndoChanges.Name = "buttonUndoChanges";
            this.buttonUndoChanges.Size = new System.Drawing.Size(145, 26);
            this.buttonUndoChanges.TabIndex = 16;
            this.buttonUndoChanges.Text = "Undo All Changes";
            this.buttonUndoChanges.UseVisualStyleBackColor = true;
            this.buttonUndoChanges.Click += new System.EventHandler(this.UndoChanges_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.AcceptsReturn = true;
            this.textBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommand.Location = new System.Drawing.Point(85, 14);
            this.textBoxCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(295, 23);
            this.textBoxCommand.TabIndex = 17;
            this.textBoxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // cubeUp
            // 
            this.cubeUp.BackColor = System.Drawing.Color.Transparent;
            this.cubeUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeUp.Face = RubiksCubeGame.RubiksCubeFiles.CubeSide.Up;
            this.cubeUp.Location = new System.Drawing.Point(154, 3);
            this.cubeUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubeUp.Name = "cubeUp";
            this.cubeUp.RoundedRadius = 5;
            this.cubeUp.RubiksCube = null;
            this.cubeUp.Size = new System.Drawing.Size(143, 159);
            this.cubeUp.TabIndex = 9;
            this.cubeUp.Text = "colorGridDisplay1";
            // 
            // cubeBack
            // 
            this.cubeBack.BackColor = System.Drawing.Color.Transparent;
            this.cubeBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeBack.Face = RubiksCubeGame.RubiksCubeFiles.CubeSide.Back;
            this.cubeBack.Location = new System.Drawing.Point(454, 167);
            this.cubeBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubeBack.Name = "cubeBack";
            this.cubeBack.RoundedRadius = 5;
            this.cubeBack.RubiksCube = null;
            this.cubeBack.Size = new System.Drawing.Size(145, 159);
            this.cubeBack.TabIndex = 3;
            this.cubeBack.Text = "colorGridDisplay1";
            // 
            // cubeFront
            // 
            this.cubeFront.BackColor = System.Drawing.Color.Transparent;
            this.cubeFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeFront.Face = RubiksCubeGame.RubiksCubeFiles.CubeSide.Front;
            this.cubeFront.Location = new System.Drawing.Point(154, 167);
            this.cubeFront.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubeFront.Name = "cubeFront";
            this.cubeFront.RoundedRadius = 5;
            this.cubeFront.RubiksCube = null;
            this.cubeFront.Size = new System.Drawing.Size(143, 159);
            this.cubeFront.TabIndex = 0;
            this.cubeFront.Text = "colorGridDisplay1";
            // 
            // cubeDown
            // 
            this.cubeDown.BackColor = System.Drawing.Color.Transparent;
            this.cubeDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeDown.Face = RubiksCubeGame.RubiksCubeFiles.CubeSide.Down;
            this.cubeDown.Location = new System.Drawing.Point(154, 331);
            this.cubeDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubeDown.Name = "cubeDown";
            this.cubeDown.RoundedRadius = 5;
            this.cubeDown.RubiksCube = null;
            this.cubeDown.Size = new System.Drawing.Size(143, 161);
            this.cubeDown.TabIndex = 11;
            this.cubeDown.Text = "colorGridDisplay1";
            // 
            // cubeRight
            // 
            this.cubeRight.BackColor = System.Drawing.Color.Transparent;
            this.cubeRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeRight.Face = RubiksCubeGame.RubiksCubeFiles.CubeSide.Right;
            this.cubeRight.Location = new System.Drawing.Point(304, 167);
            this.cubeRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubeRight.Name = "cubeRight";
            this.cubeRight.RoundedRadius = 5;
            this.cubeRight.RubiksCube = null;
            this.cubeRight.Size = new System.Drawing.Size(143, 159);
            this.cubeRight.TabIndex = 5;
            this.cubeRight.Text = "colorGridDisplay1";
            // 
            // cubeLeft
            // 
            this.cubeLeft.BackColor = System.Drawing.Color.Transparent;
            this.cubeLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeLeft.Face = RubiksCubeGame.RubiksCubeFiles.CubeSide.Left;
            this.cubeLeft.Location = new System.Drawing.Point(4, 167);
            this.cubeLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubeLeft.Name = "cubeLeft";
            this.cubeLeft.RoundedRadius = 5;
            this.cubeLeft.RubiksCube = null;
            this.cubeLeft.Size = new System.Drawing.Size(143, 159);
            this.cubeLeft.TabIndex = 7;
            this.cubeLeft.Text = "colorGridDisplay1";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.cubeUp, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.cubeBack, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.cubeFront, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.cubeDown, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.cubeRight, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.cubeLeft, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(14, 43);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(603, 495);
            this.tableLayoutPanel.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 551);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonUndoChanges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Rubiks Cube Game";
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TwoDCubeDisplay cubeFront;
        private TwoDCubeDisplay cubeBack;
        private TwoDCubeDisplay cubeLeft;
        private TwoDCubeDisplay cubeRight;
        private TwoDCubeDisplay cubeDown;
        private TwoDCubeDisplay cubeUp;
        private System.Windows.Forms.Button buttonUndoChanges;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label;
    }
}

