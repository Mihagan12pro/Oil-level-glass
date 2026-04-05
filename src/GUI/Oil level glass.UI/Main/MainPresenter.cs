namespace Oil_level_glass.UI.Main
{
    internal class MainPresenter
    {
        private readonly IMainForm _mainForm;

        public MainPresenter(IMainForm mainForm)
        {
            _mainForm = mainForm;

            _mainForm.UpdateDiameterTextBox += mainForm_UpdateDiameterTextBox;
        }

        private void mainForm_UpdateDiameterTextBox(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
