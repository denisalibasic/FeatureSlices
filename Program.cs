using FeatureSlices.Features.Books;
using FeatureSlices.Features.Movies;
using FeatureSlices.Models;
using Microsoft.EntityFrameworkCore;
using MediatR;
using FeatureSlices.Auth;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var apiKey = builder.Configuration["ApiKey"];

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Store Management API",
        Description = "API for managing store"
    });

    options.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Name = "X-API-Key",
        Type = SecuritySchemeType.ApiKey,
        In = ParameterLocation.Header,
        Description = "API key needed to access the endpoints"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "ApiKey"
                }
            },
            new List<string>()
        }
    });
});
builder.Services.AddSingleton<IApiKeyValidator>(new ApiKeyValidator(apiKey));

builder.Services.AddDbContext<MyDbContext>(options => options.UseInMemoryDatabase("StorageDB"));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddBookServices();
builder.Services.AddMovieServices();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<MyDbContext>();
    dbContext.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ApiKeyMiddleware>();

app.MapBookEndpoints();
app.MapMovieEndpoints();

app.Run();
