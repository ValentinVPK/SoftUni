using System;

namespace _13.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            Console.WriteLine($"<h1>\n    {title}\n</h1>");
            Console.WriteLine($"<article>\n    {content}\n</article>");

            string comment;

            while ((comment = Console.ReadLine()) != "end of comments")
            {
                Console.WriteLine($"<div>\n    {comment}\n</div>");
            }
        }
    }
}
