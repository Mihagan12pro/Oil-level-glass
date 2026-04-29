using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Model.Data.ScrewHoles;
using System.ComponentModel;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class HousingModel 
    : BaseDetailModel
{
    public HousingModel()
    {
        Material = new Metal();

        Chamfer = new ChamferModel()
        {
            Angle = 60
        };
    }

    public int MaxCountOfHoles {  get; set; }

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

    public BaseScrewHoleModel Hole { get; } = new BasicScrewHoleModel();

    public ChamferModel Chamfer { get; } = new ChamferModel();


    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        switch(columnName)
        {
            case nameof(MainDiameter):
                if (MainDiameter <= GlassSocketDiameter)
                    error = "Main diameter is must be greater than other diameters!";
                break;

            case nameof(MainHeight):
                if (MainHeight <= GlassSocketHeight)
                    error = "Main height must be greater than other heights!";
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

                if (property.Name == nameof(Hole))
                {
                    error += Hole.Error;
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