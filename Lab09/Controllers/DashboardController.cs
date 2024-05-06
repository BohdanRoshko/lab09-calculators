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
    public async Task<IActionResult> Index()
    {
        var operations = await _getLatestOperationsService.GetOperationsAsync(10);
        return View(operations);
    }
}