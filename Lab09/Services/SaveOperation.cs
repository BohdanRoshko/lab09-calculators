using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab09.Services
{
    public class SaveOperation : ISaveOperation
    {
        public Context _context { get; }
        public SaveOperation(Context context)
        {
            _context = context;
        }


        public async Task AddOperationAsync(Operation operation)
        {
            _context.Operations.Add(operation);
            await _context.SaveChangesAsync();
        }
    }
}
