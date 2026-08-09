namespace Shared.Results
{
    public record Result(
        bool IsSuccess, 
        string ErrorMessage = "",
        FailReason FailReason = FailReason.None);


    public enum FailReason
    {
        None,

        InvalidSelect,

        TooEarlyForConfiguring
    }
}
