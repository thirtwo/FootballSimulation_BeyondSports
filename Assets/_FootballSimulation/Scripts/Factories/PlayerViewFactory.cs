using Thirtwo.MVVM.Player;
using UnityEngine;
using Zenject;
namespace Thirtwo.Factories
{
    public class PlayerViewFactory : PlaceholderFactory<PlayerView>
    {
    }
    public class CustomPlayerViewFactory : IFactory<PlayerView>
    {
        private readonly DiContainer container;
        private readonly GameObject playerPrefab;

        public CustomPlayerViewFactory(DiContainer container, GameObject playerPrefab)
        {
            this.container = container;
            this.playerPrefab = playerPrefab;
        }
        public PlayerView Create()
        {
            return container.InjectGameObjectForComponent<PlayerView>(playerPrefab);
        }
    }
}