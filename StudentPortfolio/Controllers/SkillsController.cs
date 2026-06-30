using Microsoft.AspNetCore.Mvc;
using StudentPortfolio.Services;
namespace StudentPortfolio.Controllers;
public class SkillsController : Controller
{
    private readonly IPortfolioService _portfolioService;
    public SkillsController(IPortfolioService portfolioService) => _portfolioService = portfolioService;
    public IActionResult Index() => View(_portfolioService.GetSkills().GroupBy(s => s.Category));
}
