using Thirtwo.MVVM.Player;
using Zenject;
namespace Thirtwo.Factories
{
    public class PlayerViewModelFactory : PlaceholderFactory<PlayerViewModel>
    {
        private readonly PlayerModelFactory playerModelFactory;
        private readonly PlayerViewFactory playerViewFactory;

        public PlayerViewModelFactory(DiContainer container, PlayerViewFactory playerViewFactory,
            PlayerModelFactory playerModelFactory)
        {
            this.playerModelFactory = playerModelFactory;
            this.playerViewFactory = playerViewFactory;
        }

        public override PlayerViewModel Create()
        {
            var contain = new DiContainer();
            var playerModel = playerModelFactory.Create();
            var playerView = playerViewFactory.Create();
            contain.BindInstance(playerModel);
            contain.BindInstance(playerView);
            var playerViewModel = contain.Instantiate<PlayerViewModel>();
            return playerViewModel;
        }
    }
}
