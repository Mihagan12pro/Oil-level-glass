using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class HousingModel 
    : BaseDetailModel
{
    public HousingModel()
    {
        Material = new Metal();
    }

    private double _mainDiameter;
    public double MainDiameter
    {
        get
        {
            return _mainDiameter;
        }
        set
        {
            _mainDiameter = value;

            OnPropertyChanged();
        }
    }

    private double _mainHeight;
    public double MainHeight
    {
        get
        {
            return _mainHeight;
        }
        set
        {
            _mainHeight = value;

            OnPropertyChanged();
        }
    }

    private double _glassSocketHeight;
    public double GlassSocketHeight
    {
        get
        {
            return _glassSocketHeight;
        }
        set
        {
            _glassSocketHeight = value;

            OnPropertyChanged();
        }
    }

    private double _glassSocketDiameter;
    public double GlassSocketDiameter
    {
        get
        {
            return _glassSocketDiameter;
        }
        set
        {
            _glassSocketDiameter = value;

            OnPropertyChanged();
        }
    }

    private double _centralHoleDiameter;
    public double CentralHoleDiameter
    {
        get
        {
            return _centralHoleDiameter;
        }
        set
        {
            _centralHoleDiameter = value;

            OnPropertyChanged();
        }
    }

    private int _screwHolesCount;
    public int ScrewHolesCount
    {
        get
        {
            return _screwHolesCount;
        }
        set
        {
            _screwHolesCount = value;

            OnPropertyChanged();
        }
    }

    private double _screwHolesDistance;
    public double ScrewHolesDistance
    {
        get
        {
            return _screwHolesDistance;
        }
        set
        {
            _screwHolesDistance = value;

            OnPropertyChanged();
        }
    }

    public ThreadModel Thread { get; } = new ThreadModel();

    public ChamferModel Chamfer { get; } = new ChamferModel() { Angle = 45, Length = 5 };

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        return error;
    }
}