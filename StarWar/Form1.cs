using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWar
{
    public partial class Form1 : Form
    {
        GameBoard gb = new GameBoard(10, 10);
        Color[] colors = new Color[6] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple, Color.White };
        public Form1()
        {
            InitializeComponent();
            
        }
        private void DrawGrid()
        {
            Graphics G = gameBox.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            for (int i = 0; i < 11; i++)
            {
                G.DrawLine(pen, i * 40, 0, i * 40, 400);
            }
            for (int i = 0; i < 11; i++)
            {
                G.DrawLine(pen, 0, i * 40, 400, i * 40);
            }
        }
        private void DrawGameBox()
        {
            Graphics G = gameBox.CreateGraphics();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    G.FillRectangle(new SolidBrush(colors[gb.gameBoard[i, j]]),
                        i * 40 + 2, j * 40 + 2, 38, 38);
                }
        }
        private void DrawSelected(int[] pos)
        {
            Graphics G = gameBox.CreateGraphics();
            for (int i = 0; i < pos.Length; i++)
            {
                int x = pos[i] % 10;
                int y = pos[i] / 10;
                G.FillRectangle(new SolidBrush(Color.Gray),
                        x * 40 + 2, y * 40 + 2, 38, 38);
            }
        }
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            gb.InitializeGame();
            DrawGameBox();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            gb.InitializeGame();
            DrawGrid();
            DrawGameBox();
        }

        private void GameBox_MouseClick(object sender, MouseEventArgs e)
        {
            DrawGameBox();
            int posX = e.X / 40;
            int posY = e.Y / 40;
            int[] attached = gb.OnClick(posX, posY);
            if (attached.Length != 1)
                DrawSelected(attached);
        }

        private void GameBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int posX = e.X / 40;
            int posY = e.Y / 40;
            gb.OnDblClick(posX, posY);
            DrawGameBox();
        }
    }
}
