using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class GlassModel : BaseDetailModel
{
    public GlassModel()
    {
        Material = new Glass();

        Appearance.Transparency = 0.74;
        Appearance.Ambient = 0.5;
        Appearance.Diffuse = 0.6;
        Appearance.Specularity = 0.8;
        Appearance.Shininess = 0.8;
        Appearance.Emission = 0.5;
    }

    private double _externalDiameter;
    public double ExternalDiameter
    {
        get
        {
            return _externalDiameter; 
        }
        set
        {
            _externalDiameter = value;

            OnPropertyChanged();
        }
    }

    private double _height;
    public double Height
    {
        get
        {
            return _height;
        }
        set
        {
            _height = value;

            OnPropertyChanged();
        }
    }

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        return error;
    }
}