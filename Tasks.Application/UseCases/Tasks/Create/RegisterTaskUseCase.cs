using Tasks.Communication.Requests;
using Tasks.Communication.Responses;

namespace Tasks.Application.UseCases.Tasks.Create;
public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisterTaskJson
        {
            Id = 1,
            Title = request.Title
        };
    }
}
