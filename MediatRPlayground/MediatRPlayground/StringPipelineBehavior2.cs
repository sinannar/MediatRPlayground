using MediatR;

namespace MediatRPlayground;

public class StringPipelineBehavior2 : IPipelineBehavior<StringRequest, string>
{
    public async Task<string> Handle(StringRequest request, RequestHandlerDelegate<string> next, CancellationToken cancellationToken)
    {
        request.message = $"2-2 {request.message}";
        Console.WriteLine($"StringPipelineBehavior2 before\t\t|{request.message}");
        var response = await next();
        Console.WriteLine($"StringPipelineBehavior2 after\t\t|{request.message}");
        return response;
    }
}
