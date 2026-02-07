namespace Oil_level_glass.Model.Data.Other;

public class Name : BaseModel
{
    public string Naming { get; set; } = string.Empty;

    public string Marking { get; set; } = string.Empty;

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
}