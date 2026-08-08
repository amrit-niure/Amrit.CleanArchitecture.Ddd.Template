using Application.Interfaces;
using Domain;
using MediatR;

namespace Application.Todos.Commands.CreateTodoItem;

public class CreateTodoItemCommandHandler(ITodoItemRepository repository)
    : IRequestHandler<CreateTodoItemCommand, Guid>
{
    public async Task<Guid> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
    {
        var todoItem = new TodoItem(request.Title);

        await repository.AddAsync(todoItem, cancellationToken);

        return todoItem.Id;
    }
}
