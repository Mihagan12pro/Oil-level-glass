using Oil_level_glass.Model.Data.Entities.Parts.Interfaces;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;
using Oil_level_glass.UI.Presenters.Editors;

namespace Oil_level_glass.Presenters.Editors.Presenters.HolesEditor
{
    public interface IHolesEditorPresenter : IEditorPresenter<BasicHoleModel>
    {
        IHoleContainter Containter { get; set; }
    }
}
