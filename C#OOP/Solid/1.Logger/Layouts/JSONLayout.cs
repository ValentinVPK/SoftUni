using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Layouts
{
    public class JSONLayout : ILayout
    {
        public string Template
        {
            get
            {
                return @"""log"" : {{
  ""date"" : ""{0}"",
  ""level"" : ""{1}"",
  ""message"" : ""{2}""
}},";
            }
        }
    }
}
