var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ZapatillasVentasContext>(options =>
    options.UseSqlite("Data Source=zapatillasVentas.db"));


builder.Services.AddScoped<IZapatillaRepository, ZapatillaRepository>();
builder.Services.AddScoped<ZapatillaService>();


builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();


