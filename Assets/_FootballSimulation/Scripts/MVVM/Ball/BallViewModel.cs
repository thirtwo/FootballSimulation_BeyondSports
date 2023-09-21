using System;
using Thirtwo.Data.Simulation.Ball;
using UniRx;
using Zenject;

namespace Thirtwo.MVVM.Ball
{
    public class BallViewModel : ViewModel<BallModel, BallView>, IInitializable, IDisposable
    {
        #region Variables
        readonly CompositeDisposable compositeDisposable = new CompositeDisposable();
        #endregion
        #region Constructor
        public BallViewModel(BallView ballView, BallModel ballModel)
            : base()
        {
            Model = ballModel;
            View = ballView;
            Initialize();
        }
        #endregion
        #region Interface Methods
        public void Initialize()
        {
            Model.BallData
                .Subscribe(View.SetBallView)
                .AddTo(compositeDisposable);           
        }
        public void Dispose()
        {
            compositeDisposable.Dispose();
        }
        #endregion
        #region Class Methods
        public void SetBallData(BallData ballData)
        {
            Model.SetBallData(ballData);
        }
        #endregion
    }
}
