namespace Shared.Results
{
    public record Result(
        bool IsSuccess, 
        string ErrorMessage = "");
}
