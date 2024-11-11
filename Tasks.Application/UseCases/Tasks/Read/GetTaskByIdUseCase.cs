using Tasks.Communication.Enums;
using Tasks.Communication.Responses;

namespace Tasks.Application.UseCases.Tasks.Read;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson()
        {
            Id = id,
            Title = "Task 01",
            Description = "Task description",
            DueDate = new DateTime(year: 2023, month: 01, day: 01),
            Priority = TaskPriorityType.MEDIUM,
            Status = TaskStatusType.IN_PROGRESS
        };
    }
}
