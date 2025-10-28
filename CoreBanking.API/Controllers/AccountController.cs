using CoreBankingTest.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoreBankingTest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        public IActionResult GetAllAccounts()
        {
            var accounts = _accountRepository.GetAll();
            return Ok(accounts);
        }

        [HttpGet("{id}")]
        public IActionResult GetAccounts(int id)
        {
            var account = _accountRepository.GetById(id);
            if (account == null)
                return NotFound($"Account with Id {id} not found.");
            return Ok(account);

        }
    }
}
