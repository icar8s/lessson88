namespace MyToDoList.Data;

public class ToDoList : IToDoList
{
    private readonly List<string> _todoTasks = new List<string>();
    private readonly List<string> _doneTasks = new List<string>();
    public void Add(string task)
    {
        _todoTasks.Add(task);
    }

    public void Delete(int id)
    {
        _todoTasks.RemoveAt(id);
    }

    public void MarkAsCompleted(int id)
    {
        var task = _todoTasks[id];
        _todoTasks.RemoveAt(id);
        _doneTasks.Add(task);
    }

    public string[] ToDoItems()
    {
        return _todoTasks.ToArray();
    }

    public string[] DoneItems()
    {
        return _doneTasks.ToArray();
    }
    
    
}