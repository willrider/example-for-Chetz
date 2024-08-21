using System.Text.Json;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        if (File.Exists("config.json"))
        {
            Console.WriteLine($"Config exists, loading...");
            var deserializedJson = JsonSerializer.Deserialize<MyLauncherConfig>(File.ReadAllText("config.json"));
            Console.WriteLine($"Current Profile: {deserializedJson.CurrentProfile} \n\r" +
                              $"ID: {deserializedJson.Profiles.Where(x => x.Name == deserializedJson.CurrentProfile).First().Id}");
        }
        else
        {
            var myconfig = new MyLauncherConfig();
            var serializedJson = JsonSerializer.Serialize<MyLauncherConfig>(myconfig);
            File.WriteAllText("config.json", serializedJson);
            Console.WriteLine("Config was saved!");
        }
    }
}