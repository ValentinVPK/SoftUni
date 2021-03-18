using _1.Logger.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Core.Factories
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            ILayout layout;

            switch (type)
            {
                case nameof(SimpleLayout):
                    layout = new SimpleLayout();
                    break;
                case nameof(XmlLayout):
                    layout = new XmlLayout();
                    break;
                case nameof(JSONLayout):
                    layout = new JSONLayout();
                    break;
                default:
                    throw new ArgumentException($"{type} is invalid layout type!");
            }

            return layout;
        }
    }
}
