using Thirtwo.Data.ScriptableObjects;
using Thirtwo.Factories;
using Thirtwo.MVVM.Ball;
using Thirtwo.MVVM.Player;
using UnityEngine;
using Zenject;
namespace Thirtwo.Installers
{
    public class SimulationInstaller : MonoInstaller
    {
        [SerializeField] private GameConfig gameConfig;


        public override void InstallBindings()
        {
            Container.BindInstance(gameConfig.SimulationConfig).AsSingle();
            SetBallBindings();
            SetPlayerBindings();

            Container.BindInstance(gameConfig.SimulationDataAsset).AsSingle();
            ManagerInstaller.Install(Container);
        }

        private void SetBallBindings()
        {
            Container.Bind<BallView>().FromComponentInNewPrefab(gameConfig.BallViewPrefab).AsSingle();
            Container.Bind<BallModel>().AsSingle();
            Container.Bind<BallViewModel>().AsSingle();
        }

        private void SetPlayerBindings()
        {
            Container.BindInstance(gameConfig.PlayerViewPrefab);
            Container.BindFactory<PlayerView, PlayerViewFactory>().FromComponentInNewPrefab(gameConfig.PlayerViewPrefab);
            Container.BindFactory<PlayerModel, PlayerModelFactory>();
            Container.BindFactory<PlayerViewModel, PlayerViewModelFactory>().FromFactory<CustomPlayerViewModelFactory>();
        }
    }
}