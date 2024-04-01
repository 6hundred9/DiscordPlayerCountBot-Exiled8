using System.Threading.Tasks;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using PluginAPI.Events;
using Server = PluginAPI.Core.Server;

namespace DiscordPlayerCountBot_Exiled8
{
    public class EventHandler
    {
        public static int plrCount { get; private set; }
        public static int maxPlrCount { get; private set; }

        public static void PlayerJoin(JoinedEventArgs ev)
        {
            plrCount++;
        }

        public static void PlayerLeave(LeftEventArgs ev)
        {
            plrCount--;
        }

        public static void RoundStart()
        {
            plrCount = Server.PlayerCount;
            maxPlrCount = Server.MaxPlayers;
            DiscordPlayerCountBot_Exiled8.DiscordBot.launchBot(new Plugin().token);
            DiscordPlayerCountBot_Exiled8.DiscordBot.changeStatus(plrCount, maxPlrCount);
        }
    }
}