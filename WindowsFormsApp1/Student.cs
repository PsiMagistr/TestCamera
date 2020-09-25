using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        public int X { get; set; } = 1;
        public int Y { get; set; } = 2;
        public int DeltaX {get; set;} = 0;
        public int DeltaY { get; set; } = 0;
        public void Draw(Graphics g, int size)
        {
            g.FillRectangle(new SolidBrush(Color.Blue), X * size + 1 * (X + 1), Y * size + 1 * (Y + 1), size, size);
        }
    }
}
