using System.Collections.Generic;
using Thirtwo.Factories;
using Thirtwo.MVVM.Player;
using UnityEngine;
using Zenject;
namespace Thirtwo.Managers
{
    public class SimulationManager : MonoBehaviour
    {
        private PlayerViewModelFactory playerViewModelFactory;

        private List<PlayerViewModel> playerViewModels;
        [Inject]
        public void Construct(PlayerViewModelFactory playerViewModelFactory)
        {
            this.playerViewModelFactory = playerViewModelFactory;
            playerViewModels = new List<PlayerViewModel>();
        }

        public void SpawnPlayer()
        {
            var playerViewModel = playerViewModelFactory.Create();
            playerViewModels.Add(playerViewModel);
        }
    }
}
