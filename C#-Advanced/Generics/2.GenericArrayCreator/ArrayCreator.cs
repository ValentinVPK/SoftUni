using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] resultArr = new T[length];

            return resultArr.Select(x => x = item).ToArray();
        }
    }
}
