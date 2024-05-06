using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab09.Services;

public class GetLatestOperations : IGetLatestOperations
{
    public Context _context { get; }

    public GetLatestOperations(Context context)
    {
        _context = context;
    }


    public async Task<List<Operation>> GetOperationsAsync(int count)
    {
        var operations = await _context.Operations
            .OrderByDescending(o => o.CreatedAt)
            .Take(count).ToListAsync();
        return operations;
    }
}