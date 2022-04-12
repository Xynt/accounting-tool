using backend.Accounts.Dtos;
using backend.Accounts.Entities;
using CSharpFunctionalExtensions;

namespace backend.Accounts;

public interface IAccountService
{
    public IReadOnlyList<Account> GetAllAccounts();

    public Task<Result> AddAccount(PostAccountDto dto);
}