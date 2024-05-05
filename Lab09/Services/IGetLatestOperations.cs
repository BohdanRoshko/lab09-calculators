using Data.Models;

namespace Lab09.Services;

public interface IGetLatestOperations
{
    Task<List<Operation>> GetOperations(int count);
}