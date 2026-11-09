using System.Collections.Concurrent;
using PortfolioApi.Models;

namespace PortfolioApi.Services;

public class InMemoryContactMessageStore : IContactMessageStore
{
    private readonly ConcurrentDictionary<int, ContactMessage> _messages = new();
    private int _nextId;

    public ContactMessage Add(ContactMessageRequest request)
    {
        var message = new ContactMessage
        {
            Id = Interlocked.Increment(ref _nextId),
            Name = request.Name,
            Email = request.Email,
            Message = request.Message,
            SubmittedAtUtc = DateTime.UtcNow
        };

        _messages[message.Id] = message;
        return message;
    }

    public IReadOnlyList<ContactMessage> GetAll() => _messages.Values.OrderByDescending(m => m.SubmittedAtUtc).ToList();
}
