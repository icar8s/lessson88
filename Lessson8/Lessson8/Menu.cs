using MyToDoList.Commands;
using MyToDoList.Data;

namespace MyToDoList;
internal class Menu
{
    private readonly ToDoList _todoList = new();
    private readonly IList<ICommand> _commands = new List<ICommand>();

    private Menu()
    {
        
    }
    public static Menu Initialize()
    {
        var instance = new Menu();
        instance.FillData();
        
        
        return instance;
    }
    
    private void FillData()
    {
        _commands.Add(new ExitCommand());
        _commands.Add(new AddCommand(_todoList));
        _commands.Add(new CompleteCommand(_todoList));
        _commands.Add(new DeleteCommand(_todoList));
        
    }
    public void Start()
    {
        do
        {
            Console.WriteLine("Задачи:");
            PrintList(_todoList.ToDoItems());
            Console.WriteLine("Достижения:");
            PrintList(_todoList.DoneItems());

            for (int i = 0; i < _commands.Count; i++)
            {
                Console.Write(i + ") ");
                Console.WriteLine(_commands[i].Description);
            }
            Console.Write("=> ");

            if (int.TryParse(Console.ReadLine(), out int commandId) && commandId >= 0 && commandId < _commands.Count)
            {
                _commands[commandId].Execute();
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }
        } while (true);
    }

    private static void PrintList(string[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(i + "->");
            Console.WriteLine(list[i]);
        }
    }
}