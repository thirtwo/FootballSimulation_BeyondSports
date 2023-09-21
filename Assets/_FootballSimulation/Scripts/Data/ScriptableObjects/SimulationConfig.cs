using UnityEngine;
namespace Thirtwo.Data.ScriptableObjects
{
    [CreateAssetMenu(fileName = "SimulationConfig", menuName = "Thirtwo/Settings/SimulationConfig")]
    public class SimulationConfig : ScriptableObject
    {
        [field: Header("Team Properties")]
        [field: SerializeField] public Color Team1Color { get; private set; }
        [field: SerializeField] public Color Team2Color { get; private set; }

    }
}
