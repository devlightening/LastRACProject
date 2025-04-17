using Core.Utilities.Results.Abstracts;

namespace Core.Utilities.Results.Concretes
{
    public class Result : IResult
    {
        #region KurucuMetotlar
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        #endregion

        #region Imp
        public string Message { get; }
        public bool Success { get; }
        #endregion
    }
}