using System.Windows.Input;

namespace Oil_level_glass.Services
{
    public class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Action<object?> action;
        public Command(Action<object?> action)
        {
            this.action = action;
        }
        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => action?.Invoke(parameter);
    }
}
