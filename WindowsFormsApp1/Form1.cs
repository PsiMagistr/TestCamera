using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int X;
        private int Y;        
        private Camera camera = new Camera(45, 24);
        
        public Form1()
        {
            InitializeComponent();
          
        }

        private void scena_Paint(object sender, PaintEventArgs e)
        {            
            camera.Draw(e.Graphics, 20);
        }

      
        private void scena_MouseDown(object sender, MouseEventArgs e)
        {
           X = e.X / 21;
           Y = e.Y / 21;

          // MessageBox.Show("hhhh " + (student.X).ToString());

            if(X > camera.student.X)
            {
                camera.student.DeltaX = +1;
            }
            else if (X < camera.student.X)
            {
                camera.student.DeltaX = -1;
            }
            else
            {
                camera.student.DeltaX = 0;
            }

            if (Y > camera.student.Y)
            {
                camera.student.DeltaY = +1;
            }
            else if (Y < camera.student.Y)
            {
                camera.student.DeltaY = -1;
            }
            else
            {
                camera.student.DeltaY = 0;
            }

            if (camera.Start == false)
            {
                camera.Start = true;
            }    
        }

        private void T_Tick(object sender, EventArgs e)
        {          
            camera.Move(X, Y);
            scena.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show((Map[0].Length - MapWidth).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
