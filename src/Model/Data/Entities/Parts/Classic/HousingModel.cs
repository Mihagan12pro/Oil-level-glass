using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;
using System.ComponentModel;
using System.Reflection;

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

    public ChamferModel Chamfer { get; } = new ChamferModel();


    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        switch (columnName)
        {
            case nameof(MainDiameter):
                {
                    if (MainDiameter <= 0)
                        error = "Main diameter must be greater than zero!";
                    else if (GlassSocketDiameter >= MainDiameter)
                        error = "Main diameter must be greater than glass socket diameter";
                    else if (CentralHoleDiameter >= MainDiameter)
                        error = "Main diameter must be greater than central hole diameter";
                    else if (ScrewHolesDistance >= MainDiameter)
                        error = "Main diameter must be greater than screw holes distance";
                    break;
                }

            case nameof(MainHeight):
                if (MainHeight <= 0)
                    error = "Main height must be greater than zero!";
                else if (GlassSocketHeight >= MainHeight)
                    error = "Main height must be greater than glass socket height";
                break;

            case nameof(GlassSocketHeight):
                if (GlassSocketHeight <= 0)
                    error = "Glass socket height must be greater than zero!";
                else if (GlassSocketHeight >= MainHeight)
                    error = "Glass socket height must be less than main height";
                break;

            case nameof(GlassSocketDiameter):
                if (GlassSocketDiameter <= 0)
                    error = "Glass socket diameter must be greater than zero!";
                else if (GlassSocketDiameter >= MainDiameter)
                    error = "Glass socket diameter must be less than main diameter";
                else if (GlassSocketDiameter >= ScrewHolesDistance + Thread.NominalDiameter * 0.5)
                    error = "Glass socket diameter must be less than screw holes distance";
                else if (GlassSocketDiameter <= CentralHoleDiameter)
                    error = "Glass socket diameter must be greater than central hole diameter";
                break;

            case nameof(CentralHoleDiameter):
                if (CentralHoleDiameter <= 0)
                    error = "Central hole diameter must be greater than zero!";
                else if (CentralHoleDiameter >= GlassSocketDiameter)
                    error = "Central hole diameter must be less than glass socket diameter";
                else if (CentralHoleDiameter >= MainDiameter)
                    error = "Central hole diameter must be less than main diameter";
                break;

            case nameof(ScrewHolesCount):
                if (ScrewHolesCount < 3)
                    error = "Screw holes count must be at least 3";
                break;

            case nameof(ScrewHolesDistance):
                if (ScrewHolesDistance <= 0)
                    error = "Screw holes distance must be greater than zero!";
                else if (ScrewHolesDistance + Thread.NominalDiameter * 0.5 <= GlassSocketDiameter)
                    error = "Screw holes distance must be greater than glass socket diameter";
                else if (ScrewHolesDistance >= MainDiameter)
                    error = "Screw holes distance must be less than main diameter";
                break;

            case nameof(Thread):
                break;
        }

        return error;
    }

    public override string Error
    {
        get
        {
            string error = string.Empty;

            foreach (var property in this.GetType().GetProperties())
            {
                string propertyError = this[property.Name];
                if (property.PropertyType == typeof(ThreadModel))
                {
                    error += Thread.Error;
                }
                else if (property.PropertyType == typeof(ChamferModel))
                {
                    error += Chamfer.Error;
                }
                else
                {
                    if (propertyError != string.Empty)
                    {
                        error += propertyError + '\n';
                    }
                }
            }

            return error;
        }
    }
}