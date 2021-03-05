using _7.MilitaryElite.Enums;
using System.Collections.Generic;

namespace _7.MilitaryElite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        MissionState MissionState { get; }

        void CompleteMission();
    }
}
