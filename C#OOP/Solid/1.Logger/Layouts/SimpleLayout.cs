using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Template => "{0} - {1} - {2}";
    }
}
