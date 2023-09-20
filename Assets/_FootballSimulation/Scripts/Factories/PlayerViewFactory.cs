using Thirtwo.MVVM.Player;
using UnityEngine;
using Zenject;
namespace Thirtwo.Factories
{
    public class PlayerViewFactory : PlaceholderFactory<PlayerView>
    {
        private readonly DiContainer container;
        private readonly GameObject playerPrefab;

        public PlayerViewFactory(DiContainer container, GameObject playerPrefab)
        {
            this.container = container;
            this.playerPrefab = playerPrefab;
        }
        //TO:DO Make that with object pooling
        public override PlayerView Create()
        {
            PlayerView playerView = container.InstantiatePrefabForComponent<PlayerView>(playerPrefab);

            return playerView;
        }
    }
}