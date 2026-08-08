using Domain;

namespace Application.Interfaces;

public interface ITodoItemRepository
{
    Task AddAsync(TodoItem todoItem, CancellationToken cancellationToken);
}
