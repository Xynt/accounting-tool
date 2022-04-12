using backend.Accounts.Dtos;
using backend.Accounts.Entities;
using Microsoft.AspNetCore.Mvc;

namespace backend.Accounts;

[ApiController]
[Route("/accounts")]
public class AccountController
{
    private readonly IAccountService _accountService;

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
    public async Task<ActionResult> CreateAccount([FromBody] PostAccountDto dto)
    {
        var result = await _accountService.AddAccount(dto);
        if (result.IsFailure)
        {
            return new BadRequestObjectResult(result.Error);
        }

        return new OkResult();
    }
}