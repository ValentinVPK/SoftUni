using _7.MilitaryElite.Contracts;
using _7.MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7.MilitaryElite.Models
{

    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions;

        public Commando(string id,
            string firstName,
            string lastName,
            decimal salary,
            Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }
        public IReadOnlyCollection<IMission> Missions => missions.AsReadOnly();

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");

            foreach (var mission in this.Missions)
            {
                sb.AppendLine($"  {mission}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
