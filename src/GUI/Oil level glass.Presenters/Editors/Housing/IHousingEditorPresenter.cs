using Oil_level_glass.UI.Presenters.Editors;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Housing
{
    public interface IHousingEditorPresenter : IEditorPresenter
    {
        Result UpdateMainHeight(string mainHeight);

        Result UpdateMainDiameter(string mainDiameter);

        Result UpdateScrewHoleDiameter(string screwHoleDiameter);

        Result UpdatePicth(string pitch);

        Result UpdateScrewHolesDictance(string screwHoleDistance);

        Result UpdateScrewHolesCount(string screwHolesCount);

        Result UpdateChamferLength(string chamferLength);

        Result UpdateChamferAngle(string chamferAngle);
    }
}
