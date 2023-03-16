using Microsoft.AspNetCore.Mvc;

namespace Logger;

public static class MyEndPoint
{

    public static void MyTestEndPoint(this WebApplication app)
    {
        var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};
        ;

        app.MapGet("/weatherforecast", Test)
            .WithName("GetWeatherForecast")
            .WithOpenApi();
    }

    public static IResult Test([FromServices] IBlService bl)
    {
        bl.Test();
        return Results.Ok("");
    }
}
