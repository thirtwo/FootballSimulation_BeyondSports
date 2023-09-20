namespace Thirtwo.MVVM
{
    public class ViewModel<TModel, TView>
    where TModel : Model
    where TView : View
    {
        protected TModel Model { get; private set; }
        protected TView View { get; private set; }

        public ViewModel(TModel model, TView view)
        {
            Model = model;
            View = view;
        }
    }
}