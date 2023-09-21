using Thirtwo.MVVM.Player;
using Zenject;
namespace Thirtwo.Factories
{
    public class PlayerViewModelFactory : PlaceholderFactory<PlayerViewModel>
    {

    }
    public class CustomPlayerViewModelFactory : IFactory<PlayerViewModel>
    {
        private readonly DiContainer container;

        public CustomPlayerViewModelFactory(DiContainer container)
        {
            this.container = container;
        }
        public PlayerViewModel Create()
        {
            var playerVM = container.Instantiate<PlayerViewModel>();
            container.BindInterfacesTo<PlayerViewModel>().FromInstance(playerVM);
            return playerVM;
        }
    }
}
