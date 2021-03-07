using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public static class Validator
    {
        public static void ThrowIfInvalidValue(double value, string message)
        {
            if(value <= 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
