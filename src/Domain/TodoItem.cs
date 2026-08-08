

using Domain.Common;

namespace Blank.Domain;

internal class TodoItem : Entity
{
    private TodoItem(Guid id, string title) : base(id)
    {
        Title = title;
    }

    public string Title { get; private set; }

    public static Result<TodoItem> Create(string title)
    {
        if (string.IsNullOrWhiteSpace(title)) return Result.Failure<TodoItem>("Title is required");
        new TodoItem(title);
    }
}
