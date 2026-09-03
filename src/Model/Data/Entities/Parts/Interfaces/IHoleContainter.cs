namespace Oil_level_glass.Model.Data.Entities.Parts.Interfaces
{
    public interface IHoleContainter
    {
        int MaxHolesCount { get; set; }

        int MinHolesCount { get; }

        int HolesCount { get; set; }
    }
}
