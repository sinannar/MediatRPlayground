using MediatR;

namespace MediatRPlayground;

public class StringHandler : IRequestHandler<StringRequest, string>
{
    public async Task<string> Handle(StringRequest request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"StringHandler\t\t\t\t|{request.message}");
        return await Task.Run(() => request.message + " handled");

    }
}
