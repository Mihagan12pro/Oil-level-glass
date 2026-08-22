using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor;
using Oil_level_glass.Presenters.Editors.Presenters.Entities.Glass;
using Oil_level_glass.Presenters.Editors.Presenters.Entities.Housing;
using Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip;
using Oil_level_glass.Presenters.Editors.Presenters.HolesEditor;
using Oil_level_glass.Presenters.Presenters.Wizards.Wizard3d;

namespace Oil_level_glass.Presenters
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            //services.AddData();
            services.AddWizards();
            services.AddModelProperties();
            services.AddEntitiesPresenters();

            return services;
        }

        private static IServiceCollection AddEntitiesPresenters(this IServiceCollection services)
        {
            services.AddTransient<IGlassEditorPresenter, GlassEditorPresenter>();

            return services;
        }

        private static IServiceCollection AddWizards(this IServiceCollection services)
        {
            services.AddTransient<IWizard3dPresenter, Wizard3dPresenter>();

            return services;
        }

        //private static IServiceCollection AddData(this IServiceCollection services)
        //{
        //    services.AddTransient<IHolesEditorPresenter, HolesEditorPresenter>();
        //    services.AddTransient<IChamferEditorPresenter, ChamferEditorPresenter>();

        //    services.AddTransient<IHousingEditorPresenter, HousingEditorPresenter>();
        //    services.AddTransient<IGlassEditorPresenter, GlassEditorPresenter>();
        //    services.AddTransient<IRubberStripEditorPresenter, RubberStripEditorPresenter>();

        //    return services;
        //}

        private static IServiceCollection AddModelProperties(this IServiceCollection services)
        {
            services.AddTransient<IGlassEditorPresenter, GlassEditorPresenter>();

            return services;
        }
    }
}
