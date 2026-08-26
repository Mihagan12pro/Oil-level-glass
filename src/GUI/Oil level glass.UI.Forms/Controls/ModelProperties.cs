namespace Oil_level_glass.UI.Forms.Controls
{
    public partial class ModelProperties : UserControl
    {
        public event EventHandler? DataChanging;

        protected virtual void OnDataChanging(string propertyName)
        {
            DataChanging?.Invoke(this, new DataChangingEventArgs(propertyName));
        }
    }

    public class DataChangingEventArgs : EventArgs
    {
        public string PropertyName { get; }

        public DataChangingEventArgs(string propertyName) => PropertyName = propertyName;
    }
}
