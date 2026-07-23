namespace Shared
{
    public interface ICommand
    {
        void Execute();

        void SetAction(Action action);
    }
}
