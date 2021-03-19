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

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] fieldsInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] NonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach(FieldInfo info in fieldsInfo)
            {
                sb.AppendLine($"{info.Name} must be private!");
            }
            foreach (MethodInfo NonPublicMethod in NonPublicMethods.Where(g => g.Name.StartsWith("get")))
            {
                sb.AppendLine($"{NonPublicMethod.Name} have to be public!");
            }
            foreach (MethodInfo publicMethod in publicMethods.Where(s => s.Name.StartsWith("set")))
            {
                sb.AppendLine($"{publicMethod.Name} have to be private!");
            }


            return sb.ToString().Trim();

        }

        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);
            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach(MethodInfo method in classMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().Trim();
        }
    }
}
