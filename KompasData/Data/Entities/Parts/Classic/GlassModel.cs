using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class GlassModel : BaseDetailModel
{
    public GlassModel()
    {
        Material = new Glass();

        Appereance.Transparency = 0.74;
        Appereance.Ambient = 0.5;
        Appereance.Diffuse = 0.6;
        Appereance.Specularity = 0.8;
        Appereance.Shininess = 0.8;
        Appereance.Emission = 0.5;
    }

    public double ExternalDiameter { get; set; }

    public double Height { get; set; }

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        switch(columnName)
        {
            case nameof(ExternalDiameter):
                {
                    if (ExternalDiameter <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(Height):
                {
                    if (Height <= 0)
                        error = TooSmallValueError;

                    break;
                }
        }

        return error;
    }
}