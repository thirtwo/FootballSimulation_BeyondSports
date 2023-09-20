using System;
using UnityEngine;
namespace Thirtwo.Data.Simulation.Person
{
    [Serializable]
    public class PersonData : IMoveableSimulationEntityData
    {
        public int Id { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public Vector3 Position { get; set; }
        public float Speed { get; set; }
        public int TeamSide { get; set; }
        public int JerseyNumber { get; set; }
        public AnimationContextData AnimationContext { get; set; }
        public PersonContextData PersonContext { get; set; }


    }
}
