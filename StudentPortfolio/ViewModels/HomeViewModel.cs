using StudentPortfolio.Models;
namespace StudentPortfolio.ViewModels;
public class HomeViewModel
{
    public List<Project> FeaturedProjects { get; set; } = new();
    public List<Skill> FeaturedSkills { get; set; } = new();
}
