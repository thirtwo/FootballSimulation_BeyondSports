using Thirtwo.Data.ScriptableObjects;
using Thirtwo.Factories;
using Thirtwo.MVVM.Player;
using UnityEngine;
using Zenject;
namespace Thirtwo.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private GameConfig gameConfig;


        public override void InstallBindings()
        {
            Container.BindInstance(gameConfig.SimulationConfig).AsSingle();

            SetPlayerBindings();

            Container.BindInstance(gameConfig.SimulationDataAsset).AsSingle();
            ManagerInstaller.Install(Container);
        }

        private void SetPlayerBindings()
        {
            Container.BindInstance(gameConfig.PlayerViewPrefab);
            Container.BindFactory<PlayerView, PlayerViewFactory>();
            Container.BindFactory<PlayerModel, PlayerModelFactory>().AsTransient();
            Container.BindFactory<PlayerViewModel, PlayerViewModelFactory>().AsTransient();
        }
    }
}