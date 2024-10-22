var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Agrega servicios de controladores
builder.Services.AddEndpointsApiExplorer(); // Agrega soporte para explorar endpoints
builder.Services.AddSwaggerGen(); // Agrega soporte para Swagger

var app = builder.Build(); // Crea la aplicación

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilita Swagger en desarrollo
    app.UseSwaggerUI(); // Interfaz de usuario para Swagger
}

app.UseHttpsRedirection(); // Redirige a HTTPS
app.UseAuthorization(); // Habilita la autorización
app.MapControllers(); // Mapea controladores

app.Run(); // Ejecuta la aplicación
