using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Services;

namespace PortfolioApi.Controllers;

[ApiController]
[Route("api/portfolio")]
public class PortfolioController : ControllerBase
{
    private readonly IPortfolioDataService _data;

    public PortfolioController(IPortfolioDataService data)
    {
        _data = data;
    }

    [HttpGet("profile")]
    public IActionResult GetProfile() => Ok(_data.GetProfile());

    [HttpGet("projects")]
    public IActionResult GetProjects() => Ok(_data.GetProjects());

    [HttpGet("hepherion-labs")]
    public IActionResult GetHepherionLabsProjects() => Ok(_data.GetHepherionLabsProjects());

    [HttpGet("skills")]
    public IActionResult GetSkills() => Ok(_data.GetSkills());

    [HttpGet("certificates")]
    public IActionResult GetCertificates() => Ok(_data.GetCertificates());

    [HttpGet("features")]
    public IActionResult GetFeatures() => Ok(_data.GetFeatures());
}
