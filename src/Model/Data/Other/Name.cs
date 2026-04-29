namespace Oil_level_glass.Model.Data.Other;

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
            OnPropertyChanged();
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
            OnPropertyChanged();
        }
    }

    public override string Error
    {
        get
        {
            string error = string.Empty;

            string namingError = this[nameof(Naming)];
            if (namingError != string.Empty)
            {
                error += namingError + '\n';
            }

            return error;
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
            case nameof(Marking):
                {
                    if (string.IsNullOrEmpty(Marking))
                        error = "Marking can't be empty string!";

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