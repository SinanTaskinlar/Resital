namespace Resital.Core.Utilities.Results
{
    public class Results : IResult
    {
        public bool IsSuccess { get; }
        public string Message { get; set; }

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
    }
}