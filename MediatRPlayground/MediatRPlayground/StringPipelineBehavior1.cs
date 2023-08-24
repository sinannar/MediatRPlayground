using MediatR;

namespace MediatRPlayground;

public class StringPipelineBehavior1 : IPipelineBehavior<StringRequest, string>
{
    public async Task<string> Handle(StringRequest request, RequestHandlerDelegate<string> next, CancellationToken cancellationToken)
    {
        request.message = $"1-1 {request.message}";
        Console.WriteLine($"StringPipelineBehavior1 before\t\t|{request.message}");
        var response = await next();
        Console.WriteLine($"StringPipelineBehavior1 after\t\t|{request.message}");
        return response;
    }
}
