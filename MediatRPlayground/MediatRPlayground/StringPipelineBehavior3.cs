using MediatR;

namespace MediatRPlayground;

public class StringPipelineBehavior3 : IPipelineBehavior<StringRequest, string>
{
    public async Task<string> Handle(StringRequest request, RequestHandlerDelegate<string> next, CancellationToken cancellationToken)
    {
        request.message = $"3-3 {request.message}";
        Console.WriteLine($"StringPipelineBehavior3 before\t\t|{request.message}");
        var response = await next();
        Console.WriteLine($"StringPipelineBehavior3 after\t\t|{request.message}");
        return response;
    }
}
