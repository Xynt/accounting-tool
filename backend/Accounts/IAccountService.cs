using backend.Accounts.Dtos;
using backend.Accounts.Entities;

namespace backend.Accounts;

public interface IAccountService
{
    public IReadOnlyList<Account> GetAllAccounts();

    public Task AddAccount(PostAccountDto dto);
}