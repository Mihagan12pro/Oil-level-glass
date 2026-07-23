using Shared;

namespace Oil_level_glass.UI
{
    internal class UICommand : ICommand
    {
        private Action _action;

        public void Execute()
        {
            if (_action != null)
            {
                _action.Invoke();
            }
        }

        public void SetAction(Action action)
            => _action = action;
    }
}
