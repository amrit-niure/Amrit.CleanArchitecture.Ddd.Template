namespace Domain;

public class TodoItem
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public TodoItem(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
    }
}