using Core.Utilities.Results.Abstracts;

namespace Core.Utilities.Results.Concretes
{
    public class DataResult<TData> : Result, IDataResult<TData>
    {
        #region KurucuMetotlar
        public DataResult(TData data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(TData data, bool success) : base(success)
        {
            Data = data;
        }
        #endregion

        #region 
        public TData Data { get; }
        #endregion
    }
}