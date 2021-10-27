using CodeFirstDemo.Models;
using System;
using System.Collections.Generic;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();

            db.Database.EnsureCreated();

            db.Categories.Add(new Category
            {
                Title = "Sport",
                News = new List<News>
                {
                    new News
                    {
                        Title = "Valentin becomes the featherweight champion of the world!",
                        Content = "Valentin is the best featherweight of all time!",
                        Comments = new List<Comment>
                        {
                            new Comment {Author = "Joe Rogan", Content = "DMT"},
                            new Comment {Author = "DC", Content = "Yes"}
                        }
                    }
                }
            });

            db.SaveChanges();
        }
    }
}
