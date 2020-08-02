namespace Resital.Core.Utilities.Results
{
    public interface IResult
    {
        public bool IsSuccess { get; }
        public string Message { get; set; }
    }
}