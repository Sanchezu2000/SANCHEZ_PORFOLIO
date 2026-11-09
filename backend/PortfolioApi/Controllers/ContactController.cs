using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Models;
using PortfolioApi.Services;

namespace PortfolioApi.Controllers;

[ApiController]
[Route("api/contact")]
public class ContactController : ControllerBase
{
    private readonly IContactMessageStore _store;
    private readonly ILogger<ContactController> _logger;

    public ContactController(IContactMessageStore store, ILogger<ContactController> logger)
    {
        _store = store;
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Submit([FromBody] ContactMessageRequest request)
    {
        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }

        var saved = _store.Add(request);
        _logger.LogInformation("Contact message received from {Email}", saved.Email);

        return Ok(new { message = "Thanks for reaching out! I'll get back to you soon.", id = saved.Id });
    }
}
