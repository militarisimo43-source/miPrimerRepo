using Newtonsoft.Json.Linq;

var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

if (!File.Exists(appSettingsPath))
{
    appSettingsPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../../appsettings.json"));
}

var json = File.ReadAllText(appSettingsPath);
var root = JObject.Parse(json);

var connectionString = root["ConnectionStrings"]?["SimulationConnection"]?.Value<string>();

Console.WriteLine("Simulación de cadena de conexión:");
Console.WriteLine(connectionString ?? "No se encontró la cadena de conexión.");
