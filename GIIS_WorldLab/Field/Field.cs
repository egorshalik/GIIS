using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace GIIS_WorldLab.Field
{
    public class Field
    {
        public List<Pixel> PixelField;

        public Field(int lendthX, int lendthY, int startX, int startY, Grid grid)
        {
            PixelField = new List<Pixel>();
            for (int y = 0; y < lendthY; y++)
            {
                for (int x = 0; x < lendthX; x++)
                {
                    Pixel pixel = new Pixel(x, y);
                    pixel.Location(startX + 7 * x, startY + 7 * y);
                    grid.Children.Add(pixel.pix);
                    pixel.pix.Click += Pix_Click;
                    pixel.Color(Brushes.White);
                }
            }
        }

        private void Pix_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
