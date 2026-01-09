using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.Core.KompasDialogs
{
    /// <summary>
    /// Dialog for selecting material
    /// </summary>
    public interface IMaterialDialog
    {
        void SelectMaterial(Material material);
    }
}
