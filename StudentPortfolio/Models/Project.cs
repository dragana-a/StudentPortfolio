namespace StudentPortfolio.Models;

public class Project
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Timeline { get; set; } = string.Empty;
    public string GitHubUrl { get; set; } = string.Empty;
    public string LiveDemoUrl { get; set; } = string.Empty;
    public string DocumentationUrl { get; set; } = string.Empty;
    public List<string> TechStack { get; set; } = new();
    public List<string> Features { get; set; } = new();
    public List<string> Challenges { get; set; } = new();
    public List<string> LessonsLearned { get; set; } = new();
    public List<string> FutureImprovements { get; set; } = new();
}
