using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace DiscordPlayerCountBot_Exiled8
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;
        public static string BotToken { get; set; } = "Placeholder";

    }
}