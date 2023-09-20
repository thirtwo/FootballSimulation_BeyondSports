using UnityEngine;
namespace Thirtwo.Data.Simulation.Person
{
    [System.Serializable]
    public class PersonContextData
    {
        [field: SerializeField] public bool HasBallPossession { get; set; }
        [field: SerializeField] public int PlayerState { get; set; }
    }
}
