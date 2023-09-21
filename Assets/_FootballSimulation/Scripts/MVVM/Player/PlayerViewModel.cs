using Newtonsoft.Json;
using System;
using Thirtwo.Data.Simulation.Person;
using Thirtwo.Factories;
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
        public PlayerViewModel(PlayerViewFactory playerViewFactory, PlayerModelFactory playerModelFactory)
            : base()
        {
            Model = playerModelFactory.Create();
            View = playerViewFactory.Create();
            //This implementation is wrong. I should bind from DI but I couldn't yet
            Initialize();
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