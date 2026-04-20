using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;
using System.ComponentModel;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class HousingModel 
    : BaseDetailModel
{
    public HousingModel()
    {
        Material = new Metal();
    }

    private double _mainDiameter, _mainHeight, _glassSocketHeight, _glassSocketDiameter;
    private double _centralHoleDiameter, _screwHolesDistance;
    private int _screwHolesCount;

    [DisplayName("Main diameter")]
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

    [DisplayName("Main height")]
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

    [DisplayName("Glass socket height")]
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

    [DisplayName("Glass socket diameter")]
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

    [DisplayName("Central hole diameter")]
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

    [DisplayName("Screw holes count")]
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

    [DisplayName("Screw holes distance")]
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