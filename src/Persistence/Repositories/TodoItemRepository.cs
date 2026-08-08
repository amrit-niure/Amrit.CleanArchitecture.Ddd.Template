using Application.Interfaces;
using Domain;

namespace Persistence.Repositories;

public class TodoItemRepository(ApplicationDbContext dbContext) : ITodoItemRepository
{
    public async Task AddAsync(TodoItem todoItem, CancellationToken cancellationToken)
    {
        dbContext.TodoItems.Add(todoItem);

        await dbContext.SaveChangesAsync(cancellationToken);
    }
}
