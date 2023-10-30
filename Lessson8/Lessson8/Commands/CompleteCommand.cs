using MyToDoList.Data;

namespace MyToDoList.Commands;

public class CompleteCommand : ICommand
{
    private readonly IToDoList _toDoList;

    public CompleteCommand( IToDoList toDoList)
    {
        _toDoList = toDoList;
    }
    public string Description => "Выполнена задача";
    public void Execute()
    {
        do
        {
            Console.WriteLine("Введи id задачи");
            var successful = int.TryParse(Console.ReadLine(), out var id);

            if (successful)
            {
                _toDoList.MarkAsCompleted(id);
                break;
            }
        } while (true);
    }
}