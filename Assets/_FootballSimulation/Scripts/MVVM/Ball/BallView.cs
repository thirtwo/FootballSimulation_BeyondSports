using Thirtwo.Data.Simulation.Ball;
using UnityEngine;

namespace Thirtwo.MVVM.Ball
{
    public class BallView : View
    {
        public void SetBallView(BallData ballData)
        {
            if (ballData == null) return;
            transform.position = new Vector3(ballData.Position[0], ballData.Position[1], ballData.Position[2]);
        }
    }
}
