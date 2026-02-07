namespace Oil_level_glass.Core.Records
{
    public record DialogResult(
        bool Success, 
        string Message = "",
        string Caption = "");
}
