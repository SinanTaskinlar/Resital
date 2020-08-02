namespace Resital.Core.Utilities.Results
{
    public class Results : IResult
    {
        #region Constructor

        public Results(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Results(bool success)
        {
            IsSuccess = success;
        }

        #endregion Constructor

        public bool IsSuccess { get; }
        public string Message { get; set; }
    }
}