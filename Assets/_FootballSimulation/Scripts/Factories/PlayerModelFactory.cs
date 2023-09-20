using Thirtwo.MVVM.Player;
using Zenject;
namespace Thirtwo.Factories
{
    public class PlayerModelFactory : PlaceholderFactory<PlayerModel>
    {
        private readonly DiContainer container;

        public PlayerModelFactory(DiContainer container)
        {
            this.container = container;
        }

        public override PlayerModel Create()
        {
            PlayerModel playerModel = container.Instantiate<PlayerModel>();

            return playerModel;
        }
    }
}
