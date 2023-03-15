using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWar
{
    class GameBoard
    {
        int[,] board;
        int width;
        int height;
        public GameBoard(int x, int y)
        {
            board = new int[x, y];
            width = x;
            height = y;
        }

        public int[,] gameBoard {
            get { return board; }
        }
        public void InitializeGame()
        {
            Random rnd = new Random();
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    board[i, j] = rnd.Next(0, 4);
                }
        }
        private void Search(List<int> result, int x, int y, int value)
        {
            if (board[x, y] != value)
                return;
            if (result.IndexOf(x + y * width) != -1)
                return;
            result.Add(x + y * width);
            if ((x - 1) >=0)
                Search(result, x - 1, y, value);
            if ((x + 1) < width)
                Search(result, x + 1, y, value);
            if ((y - 1) >= 0)
                Search(result, x, y - 1, value);
            if ((y + 1) < height)
                Search(result, x, y + 1, value);
        }
        public int[] OnClick(int posX, int posY)
        {
            if (board[posX, posY] == 5)
                return new int[0];
            List<int> result = new List<int>();
            Search(result, posX, posY, board[posX, posY]);
            return result.ToArray();
        }
        private void RemoveBlank()
        {
            List<int> emptyRowIndex = new List<int>();
            for (int i = 0; i < width; i++)
            {
                bool flag = true;
                for (int j = 0; j < height; j++)
                    if (board[i, j] != 5)
                        flag = false;
                if (flag)
                    emptyRowIndex.Add(i);
            }
            for(int i = 0; i < height; i ++)
            {
                int[] newCol = new int[width];
                int k = 0;
                for (int j = 0; j < width; j++)
                    if (emptyRowIndex.IndexOf(j) == -1)
                        newCol[k++] = board[j, i];
                for (; k < width; k++)
                    newCol[k] = 5;
                for(int j = 0; j < width; j++)
                {
                    board[j, i] = newCol[j];
                }
            }
        }
        public void OnDblClick(int posX, int posY)
        {
            if (board[posX, posY] == 5)
                return;
            List<int> result = new List<int>();
            Search(result, posX, posY, board[posX, posY]);
            for(int i = 0; i < result.Count; i ++)
                board[result[i] % width, result[i] / width] = 5;
            for(int i = 0; i < width; i ++)
            {
                int[] newCol = new int[height];
                int k = height - 1;
                for(int j = height - 1; j >= 0 ; j --)
                {
                    if (board[i, j] != 5)
                        newCol[k--] = board[i, j];
                }
                for (; k >= 0; k--)
                    newCol[k] = 5;
                for(int j = 0; j < height; j ++)
                {
                    board[i, j] = newCol[j];
                }
            }
            RemoveBlank();
        }
    }
}
