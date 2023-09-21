using UnityEngine;
using TMPro;
using Zenject;
using Thirtwo.Data.ScriptableObjects;
using Thirtwo.Data.Simulation.Person;

namespace Thirtwo.MVVM.Player
{
    public class PlayerView : View
    {
        #region Variables
        [Header("Player Properties")]
        [SerializeField] private TextMeshPro jerseyText;
        [SerializeField] private MeshRenderer meshRenderer;
        [Header("Settings")]
        private SimulationConfig simulationConfig;

        #endregion
        #region Constructor
        [Inject]
        public void Construct(SimulationConfig simulationConfig)
        {
            this.simulationConfig = simulationConfig;
        }
        #endregion
        #region Class Methods
        public void SetPlayerView(PersonData personData)
        {
            jerseyText.text = personData.JerseyNumber.ToString();
            transform.position = personData.Position;
            SetTeamColor(personData.TeamSide);
        }

        private void SetTeamColor(int teamSide)
        {
            var materialPropertyBlock = new MaterialPropertyBlock();
            var color = teamSide == 1 ? simulationConfig.Team1Color : simulationConfig.Team2Color;
            materialPropertyBlock.SetColor("_Color",color);
            meshRenderer.SetPropertyBlock(materialPropertyBlock);
        }
        #endregion
        #region Editor Methods
        [ContextMenu("Set References")]
        private void SetRefs()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            jerseyText = transform.GetComponentInChildren<TextMeshPro>();
        }
        #endregion
    }
}
