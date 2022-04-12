using backend.Accounts.Dtos;
using backend.Accounts.Entities;
using Microsoft.AspNetCore.Mvc;

namespace backend.Accounts;

[ApiController]
[Route("/accounts")]
public class AccountController
{
    private IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public IReadOnlyList<Account> GetAllAccounts()
    {
        return _accountService.GetAllAccounts();
    }

    [HttpPost]
    public void CreateAccount([FromBody] PostAccountDto dto)
    {
        _accountService.AddAccount(dto);
    }
}