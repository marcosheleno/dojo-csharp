var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseLamar((context, registry) =>
{
    // register services using Lamar
    registry.For<IJsonReader>().Use<JsonReader>();
    registry.For<IRepository>().Use<Repository>();
    registry.For<IReadServices>().Use<ReadService>();

    //registry.IncludeRegistry<MyRegistry>();

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
