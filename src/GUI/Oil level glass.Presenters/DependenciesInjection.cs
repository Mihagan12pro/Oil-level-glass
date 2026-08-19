using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.Presenters.Editors.Data.ChamferEditor;
using Oil_level_glass.Presenters.Editors.Data.Entities.Glass;
using Oil_level_glass.Presenters.Editors.Data.Entities.Housing;
using Oil_level_glass.Presenters.Editors.Data.Entities.RubberStrip;
using Oil_level_glass.Presenters.Editors.Data.HolesEditor;
using Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor;
using Oil_level_glass.Presenters.ModelProperties.Folder;
using Oil_level_glass.Presenters.Wizards.Wizard3d;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;

namespace Oil_level_glass.Presenters
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddData();
            services.AddWizards();
            services.AddModelPreoperties();

            return services;
        }

        private static IServiceCollection AddWizards(this IServiceCollection services)
        {
            services.AddTransient<IWizard3dPresenter, Wizard3dPresenter>();

            return services;
        }

        private static IServiceCollection AddData(this IServiceCollection services)
        {
            services.AddTransient<IHolesEditorPresenter, HolesEditorPresenter>();
            services.AddTransient<IChamferEditorPresenter, ChamferEditorPresenter>();

            services.AddTransient<IHousingEditorPresenter, HousingEditorPresenter>();
            services.AddTransient<IGlassEditorPresenter, GlassEditorPresenter>();
            services.AddTransient<IRubberStripEditorPresenter, RubberStripEditorPresenter>();

            return services;
        }

        private static IServiceCollection AddModelPreoperties(this IServiceCollection services)
        {
            services.AddTransient<IFoldersEditorPresenter, FoldersEditorPresenter>();

            return services;
        }
    }
}
