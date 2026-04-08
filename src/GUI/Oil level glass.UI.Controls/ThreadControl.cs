namespace Oil_level_glass.UI.Controls
{
    public class ThreadControl
    {
        private readonly Control _control;
        private Action _action;

        public ThreadControl(Control control, Action action)
        {
            _control = control;
            _action = action;
        }

        public void Run()
        {
            _control.Invoke(_action);
        }
    }
}
