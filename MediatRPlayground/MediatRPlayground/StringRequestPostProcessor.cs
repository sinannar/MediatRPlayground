using MediatR.Pipeline;

namespace MediatRPlayground;

public class StringRequestPostProcessor : IRequestPostProcessor<StringRequest, string>
{
    public async Task Process(StringRequest request, string response, CancellationToken cancellationToken)
    {
        await Task.Run(() => Console.WriteLine($"StringRequestPostProcessor\t\t|{request.message}"));
    }
}
