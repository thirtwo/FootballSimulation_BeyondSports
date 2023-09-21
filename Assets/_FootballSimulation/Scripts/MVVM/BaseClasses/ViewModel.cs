namespace Thirtwo.MVVM
{
    public class ViewModel<TModel, TView>
    where TModel : Model
    where TView : View
    {
        protected TModel Model { get; set; }
        protected TView View { get; set; }

        public ViewModel()
        {

        }
    }
}