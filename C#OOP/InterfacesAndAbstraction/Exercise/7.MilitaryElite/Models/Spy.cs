using _7.MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7.MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id,string firstName, string lastName, int codeNumber)
            :base(id,firstName,lastName)
        {
            this.CodeNumber = codeNumber;
        }
        public int CodeNumber { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                Environment.NewLine +
                $"Code Number: {this.CodeNumber}";
        }
    }
}
