using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.Model.ModelProperties.Materials;
using System.ComponentModel;
using System.Globalization;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class HousingModel 
    : BaseDetailModel
{
    private double _mainDiameter, _mainHeight, _glassSocketHeight, _glassSocketDiameter;
    private double _centralHoleDiameter, _screwHolesDistance;
    private int _screwHolesCount;

    private readonly string _mainHeightGreatestMessage;
    private readonly string _mainDiameterGreaterThanSocker;

    public BaseScrewHoleModel Hole { get; } = new BasicScrewHoleModel();

    public ChamferModel Chamfer { get; } = new ChamferModel();

    public int MaxCountOfHoles;


    public HousingModel()
    {
        Material = new Metal();

        Chamfer = new ChamferModel()
        {
            Angle = 60
        };

        switch (CultureInfo.CurrentCulture.Name)
        {
            case "ru-RU":
                {
                    DisplayName = "Корпус";
                    _mainDiameterGreaterThanSocker = "Размер 'D' должен быть больше размера 'D1' минимум в 1,5 раза!";
                    _mainHeightGreatestMessage = "Размер 'h' должен быть максимальной высотой!";
                    break;
                }
            default:
                {
                    DisplayName = "Housing";
                    _mainDiameterGreaterThanSocker = "The 'D' size must be at least 1.5 times larger than the 'D1' size!";
                    _mainHeightGreatestMessage = "The 'h' size must be the greatest height!";
                    break;
                }
        }
    }

    [DisplayName("D")]
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

    [DisplayName("h")]
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

    [DisplayName("h1")]
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

    [DisplayName("D1")]
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

    [DisplayName("D2")]
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

    [DisplayName("n")]
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

    [DisplayName("D2")]
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


    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        switch(columnName)
        {
            case nameof(MainDiameter):
                if (MainDiameter / GlassSocketDiameter < 1.5)
                    error = _mainDiameterGreaterThanSocker;
                break;

            case nameof(MainHeight):
                if (MainHeight <= GlassSocketHeight)
                    error = _mainHeightGreatestMessage;
                break;
        }

        return error;
    }
}