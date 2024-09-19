using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Rectangle
    {
        public const int NumberOfCorners = 4;

        public readonly string Color;

        public Rectangle(string color)
        {
            Color = color;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Color is {Color} and number of corners is {NumberOfCorners}");
        }
    }
}
