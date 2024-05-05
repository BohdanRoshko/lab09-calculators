using Lab09.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab09.Controllers;

public class DashboardController : Controller
{
    private readonly IGetLatestOperations _getLatestOperationsService;

    public DashboardController(IGetLatestOperations getLatestOperationsService)
    {
        this._getLatestOperationsService = getLatestOperationsService;
    }
    // GET
    [Route("/Dashboard")]
    public IActionResult Index()
    {
        _getLatestOperationsService.GetOperations(10);
        return View();
    }
}