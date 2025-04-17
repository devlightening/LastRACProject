namespace Core.Utilities.Results.Abstracts
{
    public interface IDataResult<TData> : IResult
    {
        TData Data { get; }
    }
}
