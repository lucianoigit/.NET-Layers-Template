using Drugstore.Infrastructure;
using Drugstore.Api;

var builder = WebApplication.CreateBuilder(args);


// Hice un contenedores de servicios para tener mas limpio el programa
DependencyInfraestructureRegisters.ConfigureServices(builder.Services, builder.Configuration);
DependencyApiRegisters.ConfigureServices(builder.Services, builder.Configuration);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
