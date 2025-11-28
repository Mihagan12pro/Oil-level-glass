using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class HousingModel : BaseDetailModel
{
    public HousingModel()
    {
        Material = new Metal();
    }

    public double MainDiameter { get; set; }

    public double MainHeight { get; set; }

    public double GlassSocketHeight { get; set; }

    public double GlassDiameter { get; set; }

    public double CentralHoleDiameter { get; set; }

    public ChamferModel Chamfer { get; } = new() { Angle = 45, Length = 5 };

    public int ScrewHolesCount { get; set; }

    public ThreadModel Thread { get; } = new();

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        switch (columnName)
        {
            case nameof(MainDiameter):
                if (MainDiameter <= 0)
                    error = TooSmallValueError;

                break;

            case nameof(MainHeight):
                {
                    if (MainHeight <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(GlassSocketHeight):
                {
                    if (GlassSocketHeight <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(GlassDiameter):
                {
                    if (GlassDiameter <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(CentralHoleDiameter):
                {
                    if (CentralHoleDiameter <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(ScrewHolesCount):
                {
                    if (ScrewHolesCount < 4)
                        error = TooSmallValueError;

                    break;
                }
        }

        return error;
    }
}