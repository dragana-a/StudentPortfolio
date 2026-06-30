using StudentPortfolio.Models;
namespace StudentPortfolio.ViewModels;
public class ProjectsViewModel
{
    public List<Project> Projects { get; set; } = new();
    public List<string> Categories { get; set; } = new();
}
