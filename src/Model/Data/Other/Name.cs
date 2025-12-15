namespace Oil_level_glass.Model.Data.Other;

public class Name : BaseModel
{
    public string? Naming { get; set; }

    public string? Marking { get; set; }

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        if (columnName == nameof(Naming) || columnName == nameof(Marking))
            error = CheckEmptyString(columnName);

        return error;
    }
}