using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.Core.RubberStrip;
using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.UI.Editors.Housing;
using Oil_level_glass.UI.Editors.Housing.ChamferEditor;
using Oil_level_glass.UI.Editors.Housing.HolesEditor;
using Oil_level_glass.UI.Editors.ModelProperties;
using Oil_level_glass.UI.Editors.RubberStrip;
using Oil_level_glass.UI.Main;
using Oil_level_glass.UI.Wizard3d;
using Oil_level_glass.UI.Wizard3d.Editors.Glass;

namespace Oil_level_glass.UI
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddForms(
            this IServiceCollection services)
        {
            services.AddTransient<IMainView, MainForm>();
            services.AddTransient<IWizard3dView, Wizard3dForm>();

            services.AddTransient<IGlassEditorView, GlassEditorForm>();
            services.AddTransient<IRubberStripEditorView, RubberStripEditorForm>();
            services.AddTransient<IHousingEditorView, HousingEditorForm>();

            services.AddTransient<IHolesEditorView, HolesEditorForm>();
            services.AddTransient<IChamferEditorView, ChamferEditorForm>();

            services.AddTransient<IFolderEditorView, FoldersEditorForm>();

            return services;
        }
    }
}
