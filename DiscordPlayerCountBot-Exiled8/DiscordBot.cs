using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace DiscordPlayerCountBot_Exiled8
{
    public class DiscordBot
    {
        private static DiscordSocketClient _client;

        public static async Task launchBot(string token)
        {
            _client = new DiscordSocketClient();
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
        }

        public static async Task changeStatus(int plrCount, int maxPlrCount)
        {
            await _client.SetGameAsync(plrCount + "/" + maxPlrCount);
            
        }
    }
}