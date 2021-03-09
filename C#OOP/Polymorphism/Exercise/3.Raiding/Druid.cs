using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding
{
    public class Druid : BaseHero
    {
        private const int BasePower = 90;
        public Druid(string name)
            :base(name, BasePower)
        {

        }
        public override string CastAbility()
        {
            return $"{nameof(Druid)} - {this.Name} healed for {this.Power}";
        }
    }
}
