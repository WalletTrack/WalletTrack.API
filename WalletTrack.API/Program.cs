using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using WalletTrack.Persistence.Context;

public partial class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        builder.Services.AddDbContext<WalletTrackContext>(options => {
            options.UseSqlServer(builder.Configuration.GetConnectionString("WalletTrack"));
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/openapi/v1.json", "RepWitness API V1");
            });
        }

        app.MapScalarApiReference(options =>
        {
            options.Title = "My API Docs";
            options.Theme = ScalarTheme.Purple;
            options.DefaultHttpClient = new(ScalarTarget.CSharp, ScalarClient.HttpClient);
        });

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}