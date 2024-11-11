using Tasks.Communication.Responses;

namespace Tasks.Application.UseCases.Tasks.Read;
public class GetAllTasksUseCase
{
    public ResponseGetAllTasksJson Execute()
    {
        return new ResponseGetAllTasksJson
        {
            Tasks = [
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Title = "Task 1"
                },
                new ResponseShortTaskJson
                {
                    Id = 2,
                    Title = "Task 2"
                }
               ]
        };
    }
}
