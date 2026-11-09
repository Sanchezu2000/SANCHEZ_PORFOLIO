using PortfolioApi.Models;

namespace PortfolioApi.Services;

public interface IContactMessageStore
{
    ContactMessage Add(ContactMessageRequest request);
    IReadOnlyList<ContactMessage> GetAll();
}
