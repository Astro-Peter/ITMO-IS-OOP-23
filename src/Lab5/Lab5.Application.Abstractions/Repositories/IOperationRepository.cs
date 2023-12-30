using Lab5.Application.Models.Operation;

namespace Lab5.Application.Abstractions.Repositories;

public interface IOperationRepository
{
    public IEnumerable<Operation> GetAllOperations(int accountId);
}