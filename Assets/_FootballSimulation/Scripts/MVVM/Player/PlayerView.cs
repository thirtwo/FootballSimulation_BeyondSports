using UnityEngine;
using TMPro;
using Zenject;
using Thirtwo.Data.ScriptableObjects;
using Thirtwo.Data.Simulation.Person;
using Newtonsoft.Json;

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
            var data = JsonConvert.SerializeObject(personData);
            UnityEngine.Debug.Log(data);
            if (personData == null) return;
            jerseyText.text = personData.JerseyNumber.ToString();
            transform.position = new Vector3(personData.Position[0], personData.Position[1], personData.Position[2]);
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
        [ContextMenu("Set References")] //Odin Inspector Button would be great but don't have it
        private void SetRefs()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            jerseyText = transform.GetComponentInChildren<TextMeshPro>();
        }
        #endregion
    }
}
