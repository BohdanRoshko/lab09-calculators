using Data;
using Data.Models;

namespace Lab09.Services;

public class GetLatestOperations : IGetLatestOperations
{
    private readonly IDataAccess _dataAccess;

    public GetLatestOperations(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public Task<List<Operation>> GetOperations(int count)
    {
        throw new NotImplementedException();
    }
}