namespace PortfolioApi.Models;

public class ManagedProject
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Role { get; set; } = "Project Manager";
    public string Status { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public string ImageUrl { get; set; } = string.Empty;
    public string LiveUrl { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Color2 { get; set; } = string.Empty;
    public string LiveLabel { get; set; } = "Live Demo";
}
