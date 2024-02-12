using School.API.Persistence;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
    builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
    builder.Services.AddControllers()
        .AddJsonOptions(options => { options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); }); ;
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "API Сервер “Школа”",
            Description = "Api для школы с последующей интеграцией",
            Contact = new OpenApiContact
            {
                Name = "Nursat",
                Email = "makhsotnursat00@gmail.com",
                Url = new Uri("https://github.com/mnursat")
            }
        });

        // Set the comments path for the Swagger JSON and UI.
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
    });

}

var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Сервер “Школа V1");
        });
    }

    app.MapControllers();
    app.Run();
}