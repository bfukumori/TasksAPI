using Tasks.Communication.Enums;

namespace Tasks.Communication.Responses;
public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public TaskPriorityType Priority { get; set; }
    public TaskStatusType Status { get; set; }
}
