using UnityEngine;
[CreateAssetMenu(fileName = "GameConfig", menuName = "Thirtwo/Settings/GameConfig")]
public class GameConfig : ScriptableObject
{
    [field: Header("Simulation Settings")]
    [field: SerializeField] public TextAsset SimulationDataAsset { get; private set; }
    [field: Header("Player Settings")]
    [field: SerializeField] public GameObject PlayerViewPrefab { get; private set; }
}
