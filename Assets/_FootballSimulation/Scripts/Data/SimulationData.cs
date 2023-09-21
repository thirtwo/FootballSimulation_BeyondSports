using System.Collections.Generic;

namespace Thirtwo.Data.Simulation
{
    using Simulation.Person;
    using Simulation.Ball;
    using Simulation.UI;

    [System.Serializable]
    public class SimulationData
    {
        public long FrameCount { get; set; }
        public float TimestampUTC { get; set; }
        public List<PersonData> Persons { get; set; }
        public BallData Ball { get; set; }
        public GameClockContextData GameClockContext { get; set; }
        public MatchScoreContextData MatchScoreContext { get; set; }
        public PossessionCandidateContextData PossessionCandidateContext { get; set; }
    }
}
