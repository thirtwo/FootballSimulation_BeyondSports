using Thirtwo.Data.Simulation.Person;
using UniRx;
namespace Thirtwo.MVVM.Player
{
    public sealed class PlayerModel : Model
    {
        private ReactiveProperty<PersonData> personData = new ReactiveProperty<PersonData>();
        public IReactiveProperty<PersonData> PersonData => personData;

        public void SetPersonData(PersonData personData)
        {
            var data = new ReactiveProperty<PersonData>(personData);

            this.personData.Value = data.Value;
        }
    }
}
