using System;
using System.Collections.Generic;
using System.Text;

namespace _1.ClassBoxData
{
    public class Box
    {
        private double length;
        private double height;
        private double width;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Height = height;
            this.Width = width;
        }

        public double Length 
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;

            }
        }


        public double FindVolme()
        {
            return this.Length * this.Width * this.Height;
        }

        public double FindSurfaceArea()
        {
            return 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
        }

        public double FindLateralSurfaceArea()
        {
            return 2 * (this.Length * this.Height + this.Width * this.Height);
        }
    }
}
