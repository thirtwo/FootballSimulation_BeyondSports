using System;
namespace Thirtwo.Data.Simulation.UI
{
    [Serializable]
    public class GameClockContextData
    {
        public int Period { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public int InjuryTime { get; set; }
    }
}
