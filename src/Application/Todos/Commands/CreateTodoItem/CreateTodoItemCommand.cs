using MediatR;

namespace Application.Todos.Commands.CreateTodoItem;

public record CreateTodoItemCommand(string Title) : IRequest<Guid>;
