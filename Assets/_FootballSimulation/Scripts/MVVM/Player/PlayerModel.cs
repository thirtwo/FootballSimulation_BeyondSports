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
            this.personData = new ReactiveProperty<PersonData>(personData);
        }
    }
}
