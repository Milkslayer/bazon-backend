using Bazon.Backend.Api.DbModels;
using Microsoft.EntityFrameworkCore;
using Serilog;

Log.Logger = new LoggerConfiguration().
    WriteTo.Console().
    CreateBootstrapLogger();

Log.Information("Starting up");

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console());

// Add services to the container.

    builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddMvc();
    builder.Services.AddEntityFrameworkNpgsql().AddDbContext<BazonContext>(opt =>
        opt.UseNpgsql(builder.Configuration.GetConnectionString("BazonDb")));

    var app = builder.Build();
    app.UseSerilogRequestLogging();
// Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseRouting();
    app.UseAuthorization();

    app.UseEndpoints(ep => { ep.MapControllers(); });

    app.Run();
}
catch (Exception e)
{
    Log.Fatal("Application is unable to stat up: {e}", e);
}
finally
{
    Log.Information("Shut down complete");
    Log.CloseAndFlush();
}