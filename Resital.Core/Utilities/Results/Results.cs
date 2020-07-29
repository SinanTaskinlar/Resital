using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

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
        #endregion

        public bool IsSuccess { get; }
        public string Message { get; set; }
    }
}
