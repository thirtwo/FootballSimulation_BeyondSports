using System;
using UnityEngine;
namespace Thirtwo.Data.Simulation.Ball
{
    [Serializable]
    public class BallData : IMoveableSimulationEntityData
    {
        public int Id { get; set; }
        public float TimeStamp { get; set; }
        public float[] Position { get; set; }
        public float Speed { get; set; }
        public int TeamSide { get; set; }
        public int JerseyNumber { get; set; }
        public TrackableBallContextData TrackableBallContext { get; set; }

    }
}
