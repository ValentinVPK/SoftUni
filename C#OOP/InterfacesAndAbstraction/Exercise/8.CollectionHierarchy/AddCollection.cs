using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CollectionHierarchy
{
    public class AddCollection : IAdd
    {
        private List<string> collection;
        public AddCollection()
        {
            collection = new List<string>();
        }
        public int AddElement(string element)
        {
            collection.Add(element);
            return collection.Count - 1;
        }
    }
}
