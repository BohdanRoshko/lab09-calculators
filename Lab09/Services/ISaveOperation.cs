using Data.Models;

namespace Lab09.Services
{
    public interface ISaveOperation
    {
        Task AddOperationAsync(Operation operation);
    }
}
