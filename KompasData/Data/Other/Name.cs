namespace Oil_level_glass.Model.Data.Other;

public class Name : BaseModel
{
    public string? Naming { get; set; }

    public string? Marking { get; set; }

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;
        
        switch(columnName)
        {
            case nameof(Naming):
                {
                    if (string.IsNullOrWhiteSpace(Naming))
                        error = EmptyStringError;

                    break;
                }

            case nameof(Marking):
                {
                    if (string.IsNullOrWhiteSpace(Marking))
                        error = EmptyStringError;

                    break;
                }
        }

        return error;
    }
}