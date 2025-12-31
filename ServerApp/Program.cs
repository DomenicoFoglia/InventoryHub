var builder = WebApplication.CreateBuilder(args);

// Aggiungiamo il servizio CORS
builder.Services.AddCors();

var app = builder.Build();

// Configurazione CORS: permette al Client di fare domande al Server
app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.MapGet("/api/productlist", () => {
    return new[]
    {
        new
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200.50,
            Stock = 25,
            Category = new { Id = 101, Name = "Electronics" } // Oggetto annidato
        },
        new
        {
            Id = 2,
            Name = "Headphones",
            Price = 50.00,
            Stock = 100,
            Category = new { Id = 102, Name = "Accessories" } // Oggetto annidato
        }
    };
});

app.Run();