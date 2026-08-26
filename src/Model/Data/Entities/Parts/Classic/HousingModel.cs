using Oil_level_glass.Model.Data.Entities.Parts.Interfaces;
using Oil_level_glass.Model.Data.Holes;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.Model.ModelProperties.Materials;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class HousingModel : BaseDetailModel, IHoleContainter, IChamferContainer
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

        Hole.NotifyDiameterChanged += Hole_NotifyDiameterChanged;
    }

    private void Hole_NotifyDiameterChanged(double diameter)
    {
        double length = Math.PI * ScrewHolesDistance;


        if (Hole.Diameter > 0)
        {
            var value = Math.Floor(length / Hole.Diameter);

            MaxCountOfHoles = Convert.ToInt32(Math.Floor(value));
        }
    }

    public BaseHoleModel Hole { get; set; } = new BasicHoleModel();

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
    public int HolesCount
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

    public int MinCountOfHoles
        => 3;

    public void UpdateComputableFields()
    {
        _screwHolesDistance = _mainDiameter / 2 + _glassSocketDiameter / 2;

        Hole.MaxDiameter = (MainDiameter / 2 - ScrewHolesDistance / 2) * 0.9;

        Chamfer.MaxSide2 = MainHeight;

        Chamfer.MaxSide1 = (MainDiameter * 0.5 - (ScrewHolesDistance * 0.5 + ((BasicHoleModel)Hole).Diameter * 0.5)) * 0.5;
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

                case nameof(HolesCount):
                    {
                        if (HolesCount > MaxCountOfHoles)
                            error = string.Format(messageCantBeGreaterThan, displayName, MaxCountOfHoles);
                        else if (HolesCount < 3)
                            error = string.Format(messageCantBeLessThan, displayName, 3);

                        break;
                    }
            }
        }

        return error;
    }
}