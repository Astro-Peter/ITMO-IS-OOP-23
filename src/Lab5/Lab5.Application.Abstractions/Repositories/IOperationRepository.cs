using Lab5.Application.Models.Operation;
using Lab5.Application.Models.User;

namespace Lab5.Application.Abstractions.Repositories;

public interface IOperationRepository
{
    public IEnumerable<Operation> GetAllOperations(int accountId);
}