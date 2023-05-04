using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirfoilDesigner
{
    internal class AirfoilDrawer
    {
        // Function to draw the fittest airfoil to the window.
        public static void DrawAirfoil(PictureBox picBox, string airfoilNumber)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            string file = $"{airfoilNumber}.dat";
            if(!File.Exists(file))
                return;

            string[] lines = File.ReadAllLines(file);
            List<PointF> points = new List<PointF>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                PointF point = new PointF((float)Convert.ToDouble(words[0]), (float)Convert.ToDouble(words[1]));
                points.Add(point);
            }
            Graphics graphics = picBox.CreateGraphics();
            graphics.DrawLines(blackPen, points.ToArray());
        }
    }
}
