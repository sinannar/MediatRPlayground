using MediatR;

namespace MediatRPlayground;

public class StringRequest: IRequest<string>
{
    public string message { get; set; }
}
