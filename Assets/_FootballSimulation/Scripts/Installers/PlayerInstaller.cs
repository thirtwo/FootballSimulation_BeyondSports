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
            Container.BindInstance(gameConfig.PlayerViewPrefab).WithId("PlayerPrefab");
            Container.BindFactory<PlayerView, PlayerViewFactory>().AsTransient();

            Container.Bind<PlayerModel>().AsTransient();
            Container.Bind<PlayerViewModel>().AsTransient();
        }
    }
}