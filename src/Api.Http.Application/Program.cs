using Lamar.Microsoft.DependencyInjection;
using Infra = Infrastructure.Persistance.Archive;
using ContactInfra = Contact.Infrastructure;
using ContactDomain = Contact.Domain;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.



builder.Host.UseLamar((context, registry) =>
{
    // register services using Lamar
    registry.For<Infra.IJsonReader>().Use<Infra.JsonReader>();
    registry.For<ContactDomain.Contracts.IRepository>().Use<ContactInfra.Repository>();
    registry.For<ContactDomain.Contracts.IReadServices>().Use<ContactDomain.ReadService>();

    // registry.IncludeRegistry<MyRegistry>();

    // add the controllers
    registry.AddControllers();
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
