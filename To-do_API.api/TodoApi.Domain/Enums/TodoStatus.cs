namespace To_do_API.api.TodoApi.Domain.Enums
{
    // these enums defines different possible states for a Todo item.
    //::Overflødig?
    public enum TodoStatus
    {
        Pending = 0, // ToDo Task has been created but not started yet.
        InProgress = 1, // ToDo Task is currently being worked on.
        Completed = 2// TodO Task is finished.
    }
}