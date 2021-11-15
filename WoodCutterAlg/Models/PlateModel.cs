using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodCutterAlg
{
    public class PlateModel :ICloneable
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public PlateModel(int width, int heigtht)
        {
            Width = width;
            Height = heigtht;
        }
        public PlateModel()
        {

        }

        public object Clone() => this.MemberwiseClone();

    }
}
