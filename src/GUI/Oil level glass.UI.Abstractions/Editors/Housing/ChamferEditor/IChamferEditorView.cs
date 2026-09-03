using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor
{
    public interface IChamferEditorView : IEditorView
    {
        string ChamferSide1 { get; set; }
        string ChamferSide1PlaceHolder { get; set; }

        string ChamferSide2 { get; set; }
        string ChamferSide2PlaceHolder { get; set; }

        string ChamferAngle { get; set; }

        bool ChamferSideAngle { get; set; }

        delegate void ChamferTypeChanged();
        event ChamferTypeChanged ChamferTypeChangedHandler;
    }
}
