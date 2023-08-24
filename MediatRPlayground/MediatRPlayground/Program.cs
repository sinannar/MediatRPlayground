using MediatR;
using MediatRPlayground;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    cfg.AddBehavior<StringPipelineBehavior1>();
    cfg.AddBehavior<StringPipelineBehavior2>();
    cfg.AddBehavior<StringPipelineBehavior3>();
    cfg.AddRequestPreProcessor<StringRequestPreProcessor>();
    cfg.AddRequestPostProcessor<StringRequestPostProcessor>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
