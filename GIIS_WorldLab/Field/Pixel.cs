using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GIIS_WorldLab.Field
{
    public class Pixel
    {
        public int LocX { get; set; }
        public int LocY { get; set; }
        public Button pix;

        public void Color(Brush brush)
        {
            pix.Background = brush;
        }

        public Pixel(int x, int y) {
            LocX = x;
            LocY = y;
            pix = new Button();
            Initial();
        }

        public void Location(int x, int y)
        {
            pix.Margin = new Thickness(x, y, 0, 0);
        }

        private void Initial()
        {
            pix.Height = 6;
            pix.Width = 6;
            pix.VerticalAlignment = VerticalAlignment.Top;
            pix.HorizontalAlignment = HorizontalAlignment.Left;
        }
    }
}
