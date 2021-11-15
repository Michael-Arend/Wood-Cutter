using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodCutterAlg
{
    public class BasicPlateModel
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get => Width*Height; }

        public List<BasicSquare> Squares { get; set; } = new List<BasicSquare>();

        public BasicPlateModel(int width, int height)
        {
            Width = width;
            Height = height;
            for(var x = 1; x <= width; x++)
            {
                for(var y = 1; y <= height; y++)
                {
                    Squares.Add(new BasicSquare { X = x, Y= y, Used = false });
                }
            }
        }

        public BasicPlateModel()
        {

        }

        public bool ChangeSize(int newWidth, int newHeight)
        {
            if (Squares.Any(s => s.X > newWidth && s.Used || s.Y > newHeight && s.Used)) return false;

            if(newWidth < Width)
            {
                Width = newWidth;
                Squares.RemoveAll(s => s.X > newWidth);
            };
            if (newHeight < Height && !Squares.Any(s => s.X > newHeight && s.Used))
            {
                Width = newWidth;
                Squares.RemoveAll(s => s.Y >  newHeight);
            };

            if( newWidth > Width || newHeight > Height)
            {
                Width = newWidth;
                Height = newHeight;

                for (var x = 1; x <= Width; x++)
                {
                    for (var y = 1; y <= Height; y++)
                    {
                        if(!Squares.Any(s=> x==s.X && s.Y == y))
                        Squares.Add(new BasicSquare { X = x, Y= y, Used = false });
                    }
                }
            }
            return true;
        }


    }


    public class BasicSquare
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Used { get; set; }
    }
}
