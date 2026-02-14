using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class RubberStripModel : BaseDetailModel
{
    private double _internalDiameter;
    public double InternalDiameter
    {
        get
        {
            return _internalDiameter; 
        }
        set
        {
            _internalDiameter = value;

            OnPropertyChanged();
        }
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

        switch(columnName)
        {
            case nameof(Height):
                {
                    if (Height <= 0)
                        error = "Ring height must be greater than zero!";

                    break;
                }
            case nameof(InternalDiameter):
                {
                    if (InternalDiameter <= 0)
                        error = "Ring height must be greater than zero!";

                    break;
                }
            case nameof(ExternalDiameter):
                {
                    if (ExternalDiameter <= 0)
                        error = "Ring height must be greater than zero!";

                    break;
                }
        }

        return error;
    }


    public RubberStripModel()
    {
        Material = new Rubber();
    }
}