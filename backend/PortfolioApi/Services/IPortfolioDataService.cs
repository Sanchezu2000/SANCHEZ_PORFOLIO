using PortfolioApi.Models;

namespace PortfolioApi.Services;

public interface IPortfolioDataService
{
    Profile GetProfile();
    IReadOnlyList<Project> GetProjects();
    IReadOnlyList<ManagedProject> GetHepherionLabsProjects();
    IReadOnlyList<SkillCategory> GetSkills();
    IReadOnlyList<Certificate> GetCertificates();
    IReadOnlyList<Feature> GetFeatures();
}
