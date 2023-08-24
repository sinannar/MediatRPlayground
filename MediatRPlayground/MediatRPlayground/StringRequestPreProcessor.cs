using MediatR;
using MediatR.Pipeline;

namespace MediatRPlayground;

public class StringRequestPreProcessor : IRequestPreProcessor<StringRequest>
{
    public async Task Process(StringRequest request, CancellationToken cancellationToken)
    {
        await Task.Run(() => Console.WriteLine($"StringRequestPreProcessor\t\t|{request.message}"));
    }
}
