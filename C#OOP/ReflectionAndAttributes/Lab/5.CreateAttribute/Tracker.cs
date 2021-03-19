using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type[] allTypes = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var type in allTypes)
            {
                PrintAllMethodAuthors(type);

                if (!type.GetCustomAttributes().Any(t => t.GetType() == typeof(AuthorAttribute)))
                {
                    continue;
                }

                AuthorAttribute[] attributes = type.GetCustomAttributes()
                    .Where(t => t.GetType() == typeof(AuthorAttribute))
                    .Select(t => (AuthorAttribute)t)
                    .ToArray();

                foreach(var attribute in attributes)
                {
                    Console.WriteLine($"{type.Name} created by {attribute.Name}");
                }
            }
        }

        private void PrintAllMethodAuthors(Type type)
        {
            MethodInfo[] methods = type.GetMethods();

            foreach(var method in methods)
            {
                if(!method.GetCustomAttributes()
                    .Any(a => a.GetType() == typeof(AuthorAttribute)))
                {
                    continue;
                }

                Attribute[] authorAttributes = method.GetCustomAttributes().ToArray();

                foreach(var attribute in authorAttributes)
                {
                    if(attribute is AuthorAttribute)
                    {
                        AuthorAttribute author = (AuthorAttribute)attribute;
                        Console.WriteLine($"{method.Name} is written by {author.Name}");
                    }
                }
            }
        }
    }
}
