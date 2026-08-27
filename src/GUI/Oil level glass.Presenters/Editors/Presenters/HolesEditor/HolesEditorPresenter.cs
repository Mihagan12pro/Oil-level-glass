using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.Model.Data.Entities.Parts.Interfaces;
using Oil_level_glass.Model.Data.Holes;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;
using Oil_level_glass.UI.Abstractions.ToolEditors;

namespace Oil_level_glass.Presenters.Editors.Presenters.HolesEditor
{
    internal class HolesEditorPresenter : IHolesEditorPresenter
    {
        public BaseHoleModel Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public IHoleContainter Containter { get; set; }

        public void ActivateView()
            => _view.ShowView();


        public HolesEditorPresenter(IHolesEditorView view, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _view = view;

            _view.ConfigHolesCountHandler += view_ConfigHolesCountHandler;
            _view.ConfigHolesSizesHandler += view_ConfigHolesSizesHandler;
        }

        private void view_ConfigHolesSizesHandler()
        {
            if (Model is BasicHoleModel basic)
            {
                using (var diameterView = _serviceProvider.GetRequiredService<INumberEditor<double>>())
                {
                    diameterView.Header = "Редактор диаметра отверстия";
                    diameterView.Min = Model.MinDiameter;
                    diameterView.Max = Model.MaxDiameter;
                    diameterView.Value = Model.Diameter;

                    diameterView.ShowView();

                    if (diameterView.Result)
                        Model.Diameter = diameterView.Value;
                }
            }
        }

        private void view_ConfigHolesCountHandler(out bool result, out string message)
        {
            if (!Model.HasErrors)
            {
                using (var countView = _serviceProvider.GetRequiredService<INumberEditor<int>>())
                {
                    countView.Header = "Редактор числа отверстий";
                    countView.Max = Containter.MaxHolesCount;
                    countView.Min = Containter.MinHolesCount;
                    countView.Value = Containter.HolesCount;

                    countView.ShowView();

                    if (countView.Result)
                        Containter.HolesCount = countView.Value;
                }

                message = string.Empty;
                result = true;

                return;
            }

            result = false;
            message = "Перед конфигурацией числа отверстий надо сконфигурировать размеры отверстия!";
        }

        private readonly IHolesEditorView _view;
        private readonly IServiceProvider _serviceProvider;

        private BaseHoleModel _model;
    }
}
