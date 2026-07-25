using Shared;

namespace Oil_level_glass.UI.Abstractions
{
    public class UICommand : ICommand
    {
        private Action _action;

        public void Execute()
        {
            if (_action != null )
            {
                _action();
            }
        }

        public void SetAction(Action action)
            => _action = action;
    }
}
