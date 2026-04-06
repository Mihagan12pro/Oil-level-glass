namespace Shared
{
    public record Result(
        bool IsSuccess, 
        string ErrorMessage = "");
}
