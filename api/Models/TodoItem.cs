namespace api.Models;

public class TodoItem {

    // `Id` functions as the unique key in a relational database
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}