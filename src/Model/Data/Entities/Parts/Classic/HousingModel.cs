using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.Model.ModelProperties.Materials;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class HousingModel 
    : BaseDetailModel
{
    private double _mainDiameter, _mainHeight, _glassSocketHeight, _glassSocketDiameter;
    private double _centralHoleDiameter, _screwHolesDistance;
    private int _screwHolesCount, _maxCountOfHoles;

    private readonly string _messageMainHeightGreatest;
    private readonly string _messageMainDiameterGreaterThanSocker;
    private readonly string _messageMinimalCountOfHoles;


    public HousingModel()
    {
        Material = new Metal();

        Chamfer = new ChamferModel();

        switch (CultureInfo.CurrentCulture.Name)
        {
            case "ru-RU":
                {
                    DisplayName = "Корпус";
                    _messageMinimalCountOfHoles = "Минимальное число отверстий не может быть меньше 3!";
                    _messageMainDiameterGreaterThanSocker = "Размер 'D' должен быть больше размера 'D1' минимум в 1,5 раза!";
                    _messageMainHeightGreatest = "Размер 'h' должен быть максимальной высотой!";
                    break;
                }
            default:
                {
                    DisplayName = "Housing";
                    _messageMinimalCountOfHoles = "Minimal count of screw holes can't be less than 3!";
                    _messageMainDiameterGreaterThanSocker = "The 'D' size must be at least 1.5 times larger than the 'D1' size!";
                    _messageMainHeightGreatest = "The 'h' size must be the greatest height!";
                    break;
                }
        }

        (Hole as BasicScrewHoleModel).NotifyDiameterChanged += NotifyHoleDiameterChanged;
    }

    private void NotifyHoleDiameterChanged(double diameter)
    {
        double length = Math.PI * ScrewHolesDistance;

        if ((Hole as BasicScrewHoleModel).Diameter > 0)
        {
            var value = Math.Floor(length / (Hole as BasicScrewHoleModel).Diameter);

            MaxCountOfHoles = Convert.ToInt32(Math.Floor(value));
        }
    }

    public BaseScrewHoleModel Hole { get; } = new BasicScrewHoleModel();

    public ChamferModel Chamfer { get; } = new ChamferModel();

    public int MaxCountOfHoles
    {
        get
        {
            return _maxCountOfHoles;
        }
        set
        {
            _maxCountOfHoles = value;
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

            UpdateComputableFields();
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

            UpdateComputableFields();
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

            UpdateComputableFields();
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

            UpdateComputableFields();
        }
    }

    public void UpdateComputableFields()
    {
        _screwHolesDistance = _mainDiameter / 2 + _glassSocketDiameter / 2;

        Hole.MaxDiameter = (MainDiameter / 2 - ScrewHolesDistance / 2) * 0.9;

        Chamfer.MaxSide2 = MainHeight;

        Chamfer.MaxSide1 = (MainDiameter * 0.5 - (ScrewHolesDistance * 0.5 + ((BasicScrewHoleModel)Hole).Diameter * 0.5)) * 0.5;
    }


    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        string? displayName = this.GetType()
                                  .GetProperties()
                                  .Where(p => p.GetCustomAttribute<DisplayNameAttribute>() != null && p.Name == columnName)
                                  .Select(p => p.GetCustomAttribute<DisplayNameAttribute>().DisplayName)
                                  .FirstOrDefault();

        if (displayName != null)
        {
            switch (columnName)
            {
                case nameof(MainDiameter):
                    {
                        if (MainDiameter / GlassSocketDiameter < 1.5)
                            error = _messageMainDiameterGreaterThanSocker;
                        break;
                    }

                case nameof(MainHeight):
                    {
                        if (MainHeight <= GlassSocketHeight)
                            error = _messageMainHeightGreatest;
                        break;
                    }

                case nameof(ScrewHolesCount):
                    {
                        if (ScrewHolesCount > MaxCountOfHoles)
                            error = string.Format(messageCantBeGreaterThan, displayName, MaxCountOfHoles);
                        else if (ScrewHolesCount < 3)
                            error = string.Format(messageCantBeLessThan, displayName, 3);

                        break;
                    }
            }
        }

        return error;
    }
}