using Tasks.Communication.Enums;

namespace Tasks.Communication.Requests;
public class RequestTaskJson
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriorityType Priority { get; set; }
    public DateTime DueDate { get; set; }
    public TaskStatusType? Status { get; set; } = TaskStatusType.PENDING;
}
