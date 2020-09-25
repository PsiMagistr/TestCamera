using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Camera
    {
        private byte[][] Map { get; set; }
        private int Width {get; set;} //45
        private int Height { get; set; } //24
        private int factor { get; set; }
        private int Delta { get; set; }
        private int Step { get; set; }
        public bool Start { get; set; }
        public Student student;
        public Camera(int width, int height) //
        {
            Width = width;
            Height = height;
            Delta = 0;
            Step = 0;
            Map = new byte[height][];
            factor = 3;
            student = new Student();
            for (int y = 0; y < Height; y++)
            {
                Map[y] = new byte[Width * factor]; //Проверить +1
            }

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Map[0].Length; x++)
                {
                    if (x == 0 || x == Map[0].Length - 1 || y == 0 || y == Map.Length - 1)
                    {
                        Map[y][x] = 7;
                    }
                    else
                    {
                        Map[y][x] = 0;
                    }
                }
            }

            Map[5][5] = 1;
            Map[3][3] = 1;
            Map[11][11] = 1;
            Map[10][20] = 1;
            Map[18][25] = 1;
            Map[17][30] = 1;
            Map[15][35] = 1;
            Map[10][40] = 1;
            Map[14][45] = 1;
            Map[9][50] = 1;
            Map[11][55] = 1;
            Map[7][60] = 1;
            Map[5][65] = 1;
            Map[10][73] = 1;
            Map[15][75] = 1;
            Map[12][83] = 1;
            Map[8][85] = 1;
            Map[14][92] = 1;
            Map[16][95] = 1;
            Map[16][100] = 1;
            Map[13][109] = 1;
            Map[7][108] = 1;
            Map[12][90] = 1;
           /* Start = true;*/
        }

        public void Move(int x, int y)
        {
            if (Start)
            {
                student.Y += student.DeltaY;
                if (Delta == 0 && student.X <= Width / 2 || Delta == 0 && x <= Width / 2 || Delta == Map[0].Length - Width && student.X != Width / 2 || Delta == Map[0].Length - Width && x > Width / 2)
                {
                    student.X += student.DeltaX;
                }
                else if (Delta <= Map[0].Length)
                {

                    Delta += student.DeltaX;
                    Step += student.DeltaX;
                }
                // MessageBox.Show("Дельта " + delta.ToString() + " " + (X - student.X).ToString());
                if (student.X == x || Step == x - student.X)
                {
                    Step = 0;
                    // MessageBox.Show("Дельта " + delta.ToString() + " " + (X - student.X).ToString());
                    if(student.Y == y)
                    Start = false;
                }               
            }         
           
        }

        public void Draw(Graphics g, int size)
        {
            Color[] colors = new Color[9] {
                Color.LightGreen,
                Color.Green,
                Color.Gray,
                Color.Orange,
                Color.LightGray,
                Color.Blue,
                Color.Red,
                Color.Fuchsia,
                Color.DeepSkyBlue
            };
            for (int y = 0; y < Map.Length; y++)
            {
                for (int x = Delta; x < Width + Delta; x++)
                {
                    g.FillRectangle(new SolidBrush(colors[Map[y][x]]), (x * size + 1 * (x + 1)) - (Delta * size) - Delta + 1, y * size + 1 * (y + 1), size, size);
                }
            }
            student.Draw(g, size);
        }
    }
}
