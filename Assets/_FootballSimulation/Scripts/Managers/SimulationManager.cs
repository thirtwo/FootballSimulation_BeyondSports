using System;
using System.Collections.Generic;
using Thirtwo.Data.Simulation;
using Thirtwo.Factories;
using Thirtwo.MVVM.Player;
using Thirtwo.Serializer.Simulation;
using Zenject;
using Cysharp.Threading.Tasks;
using Thirtwo.Data.Simulation.Person;
using UnityEngine;

namespace Thirtwo.Managers
{
    public class SimulationManager : IInitializable, IDisposable
    {
        #region Variables
        private readonly PlayerViewModelFactory playerViewModelFactory;
        private readonly SimulationSerializer simulationSerializer;

        private List<SimulationData> simulationDatas;
        private Dictionary<int, PlayerViewModel> playerViewModels;
        #endregion
        #region Constructor
        public SimulationManager(PlayerViewModelFactory playerViewModelFactory, SimulationSerializer simulationSerializer)
        {
            this.playerViewModelFactory = playerViewModelFactory;
            this.simulationSerializer = simulationSerializer;
        }
        #endregion
        #region Interface Methods
        public void Initialize()
        {
            playerViewModels = new Dictionary<int, PlayerViewModel>();
            simulationSerializer.SerializeData();
            simulationDatas = simulationSerializer.GetSimulationDatas();
            InitSimulation();
        }
        public void Dispose()
        {
            simulationDatas.Clear();
            playerViewModels.Clear();
        }
        #endregion
        #region Class Methods
        private async UniTaskVoid InitSimulation()
        {
            for (int i = 0; i < simulationDatas.Count; i++)
            {
                SetSimulationFrame(simulationDatas[i]);
                await UniTask.Yield();
            }
        }
        private void SetSimulationFrame(SimulationData simulationData)
        {
            //Set Ball
            //Set Match score
            for (int i = 0; i < simulationData.Persons.Count; i++)
            {
                SetPlayerViewModel(simulationData.Persons[i]);
            }
        }
        private void SetPlayerViewModel(PersonData personData)
        {
            if (!playerViewModels.TryGetValue(personData.Id, out var playerViewModel))
            {
                playerViewModel = playerViewModelFactory.Create();
                playerViewModel.SetPersonData(personData);
                playerViewModels.Add(personData.Id, playerViewModel);
            }
            else
            {
                playerViewModel.SetPersonData(personData);
            }
        }
        #endregion
    }
}
