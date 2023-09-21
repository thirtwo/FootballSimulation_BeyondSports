using Thirtwo.Data.Simulation.Ball;
using UniRx;
namespace Thirtwo.MVVM.Ball
{
    public class BallModel : Model
    {
        private ReactiveProperty<BallData> ballData = new ReactiveProperty<BallData>();
        public IReactiveProperty<BallData> BallData => ballData;

        public void SetBallData(BallData ballData)
        {
            var data = new ReactiveProperty<BallData>(ballData);

            this.ballData.Value = data.Value;
        }
    }
}
