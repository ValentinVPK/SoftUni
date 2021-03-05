using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CollectionHierarchy
{
    public class MyList : IAdd, IRemove
    {
        private List<string> collection;
        public MyList()
        {
            collection = new List<string>();
        }
        public int AddElement(string element)
        {
            collection.Insert(0, element);

            return 0;
        }

        public string RemoveElement()
        {
            string removedElement = collection[0];
            collection.RemoveAt(0);

            return removedElement;
        }
    }
}
