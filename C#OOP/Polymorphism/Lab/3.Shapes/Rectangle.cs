using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get => this.height;
            private set
            {
                Validator.ThrowIfInvalidValue(value, "Invalid height");

                this.height = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                Validator.ThrowIfInvalidValue(value, "Invalid width");
                this.width = value;
            }
        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Height + 2 * this.Width;
        }

        public override string Draw()
        {
            return "Drawing rectangle.";
        }
    }
}
