using System;
using Thirtwo.Data.Simulation.Person;
using UniRx;
using Zenject;
namespace Thirtwo.MVVM.Player
{
    public class PlayerViewModel : ViewModel<PlayerModel, PlayerView>, IInitializable, IDisposable
    {
        #region Variables
        private int id;
        public int Id => id;
        // We can dispose multiple reactives
        readonly CompositeDisposable compositeDisposable = new CompositeDisposable();
        #endregion
        #region Constructor
        public PlayerViewModel(PlayerModel model, PlayerView view)
            : base(model, view)
        {

        }
        #endregion
        #region Interface Methods
        public void Initialize()
        {
            Model.PersonData    
                .Subscribe(View.SetPlayerView)
                .AddTo(compositeDisposable);
        }
        public void Dispose()
        {
            compositeDisposable.Dispose();
        }
        #endregion
        #region Class Methods
        public void SetPersonData(PersonData personData)
        {
            id = personData.Id;
            Model.SetPersonData(personData);
        }
        #endregion

    }
}