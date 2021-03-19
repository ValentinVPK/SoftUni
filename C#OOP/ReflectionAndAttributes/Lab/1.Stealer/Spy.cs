using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass,params string[] fields)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] fieldsInfo = classType.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

            Object objectInstance = Activator.CreateInstance(classType, new object[] { });

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach(FieldInfo info in fieldsInfo.Where(f => fields.Contains(f.Name)))
            {
                sb.AppendLine($"{info.Name} = {info.GetValue(objectInstance)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
