using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.Core.KompasDialogs
{
    /// <summary>
    /// Dialog for selecting material
    /// </summary>
    public interface IMaterialsDialog
    {
        void SelectMaterial(Material material);
    }
}
