using MyToDoList.Data;

namespace MyToDoList.Commands;

public class DeleteCommand: ICommand
{
    private readonly IToDoList _toDoList;

    public DeleteCommand( IToDoList toDoList)
    {
        _toDoList = toDoList;
    }
    public string Description => "Удалить задачу";
    public void Execute()
    {
        do
        {
            Console.WriteLine("Введи id задачи");
            var successful = int.TryParse(Console.ReadLine(), out var id);

            if (successful)
            {
                _toDoList.Delete(id);
                break;
            }
        } while (true);
    }
}