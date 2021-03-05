using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CollectionHierarchy
{
    public class AddRemoveCollection : IRemove, IAdd
    {
        private List<string> collection;
        public AddRemoveCollection()
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
            string removedElement = collection[collection.Count - 1];
            collection.RemoveAt(collection.Count - 1);

            return removedElement;
        }
    }
}
