namespace Thirtwo.MVVM.Player
{
    public class PlayerViewModel : ViewModel<PlayerModel, PlayerView>
    {
        public PlayerViewModel(PlayerModel model, PlayerView view)
            : base(model, view)
        {

        }
    }
}