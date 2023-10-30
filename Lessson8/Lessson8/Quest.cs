namespace MyToDoList;

public class Quest
{
    public string Name { get; }
    public bool IsCompleted { get; private set; }
    public DateTime Created { get; }
    public DateTime Updated { get; private set; }

    public Quest(string name)
    {
        Name = name;
        Created = DateTime.Now;
    }

    public void Complete()
    {
        IsCompleted = true;
        Updated = DateTime.Now;
    }
        
}