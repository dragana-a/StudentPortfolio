namespace StudentPortfolio.Models;

public class Skill
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Proficiency { get; set; }
    public string IconClass { get; set; } = "bi bi-code-slash";
}
