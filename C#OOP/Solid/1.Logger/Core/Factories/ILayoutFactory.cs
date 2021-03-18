using _1.Logger.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Core.Factories
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);

    }
}
