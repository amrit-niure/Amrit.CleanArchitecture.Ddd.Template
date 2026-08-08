
using Domain.Common;

namespace Blank.Domain.Errors;

public class TodoItemError
{
    public static Error TitleRequiredError = new("TodoItem.TitleRequired", "Title is required");
}
