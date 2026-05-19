using System.Text.Json;

var appSettingsPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

if (File.Exists(appSettingsPath))
{
    try
    {
        var json = JsonDocument.Parse(File.ReadAllText(appSettingsPath));
        if (json.RootElement.TryGetProperty("ConnectionStrings", out var connectionStrings) &&
            connectionStrings.TryGetProperty("DefaultConnection", out var defaultConnection))
        {
            Console.WriteLine("Simulación de cadena de conexión:");
            Console.WriteLine(defaultConnection.GetString());
        }
        else
        {
            Console.WriteLine("No se encontró la cadena de conexión en appsettings.json.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error leyendo appsettings.json: {ex.Message}");
    }
}
else
{
    Console.WriteLine($"No se encontró appsettings.json en {appSettingsPath}");
}

Console.WriteLine("Hello, Platzi World Sebastian!");

string stripe_api_key="sk_test_4eC39HqLyjWDvYjJt9nqT3m00Qy2ZtXoL";

string testingconnectio="Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";    

