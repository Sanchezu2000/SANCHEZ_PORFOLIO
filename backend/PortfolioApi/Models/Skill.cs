namespace PortfolioApi.Models;

public class SkillItem
{
    public string Name { get; set; } = string.Empty;

    // "cdn" -> Icon is a simpleicons.org slug; "custom" -> Icon is a key handled by the frontend's icon registry.
    public string IconType { get; set; } = "cdn";
    public string Icon { get; set; } = string.Empty;

    // Number of projects whose tags reference this skill. Computed from the real project data, not hand-entered.
    public int ProjectCount { get; set; }
}

public class SkillCategory
{
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public List<SkillItem> Items { get; set; } = new();
}
