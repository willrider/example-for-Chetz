using System.Text.Json;

namespace ConsoleApp1;

public class MyLauncherConfig
{
    public string CurrentProfile { get; set; } = "MHWorld";
    public Profile[] Profiles { get; set; } = new Profile[1]
    {
        new Profile()
        {
            Id = 1,
            Name = "MHWorld",
            KeysDefinition = new Dictionary<string, string>
            {
                { "1", "C:\\apps\\1.exe" },
                { "2", "C:\\apps\\2.exe" },
                { "3", "C:\\apps\\3.exe" },
                { "4", "C:\\apps\\4.exe" },
                { "5", "C:\\apps\\5.exe" }
            }
        },
    };
}

public class Profile
{
    public string Name { get; set; }
    public long Id { get; set; }
    public Dictionary<string, string> KeysDefinition { get; set; }
}

