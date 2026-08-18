namespace Oil_level_glass.Model.ModelProperties.Other;

public class Name : BaseModel
{
    private string? _naming;
    public string? Naming
    {
        get
        {
            return _naming; 
        }
        set
        {
            _naming = value;
            
        }
    }

    private string? _marking;
    public string? Marking
    {
        get
        {
            return _marking;
        }
        set
        {
            _marking = value;
            
        }
    }

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        switch(columnName)
        {
            case nameof(Naming):
                {
                    if (string.IsNullOrEmpty(Naming))
                        error = "Naming can't be empty string!";

                    break;
                }
        }

        return error;
    }

    public Name()
    {
        Naming = string.Empty;
        Marking = string.Empty;
    }
}