namespace Oil_level_glass.UI.Abstractions
{
    public interface IView : IDisposable
    {
        void ShowView(
            bool doModal, 
            object owner = null);
    }
}
