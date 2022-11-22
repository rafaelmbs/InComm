using Microsoft.AspNetCore.Mvc;

namespace InComm.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MigrateController : ControllerBase
{
    private readonly ILogger<MigrateController> _logger;

    public MigrateController(ILogger<MigrateController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMigrate")]
    public IEnumerable<string> Get()
    {
        return new[] { string.Empty };
    }
}
