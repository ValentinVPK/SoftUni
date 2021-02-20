using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.Badges = 0;
            Collection = new List<Pokemon>();
            Collection.Add(pokemon);
        }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Collection { get; set; }

    }
}
