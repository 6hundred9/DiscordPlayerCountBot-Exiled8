using System;
using Exiled.API.Features;

namespace DiscordPlayerCountBot_Exiled8
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Discord Player Count Bot";
        public override string Author { get; } = "6hundred9";
        public override string Prefix { get; } = "dcPlayerCount";
        public override Version Version { get; } = new Version(0, 1, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 0);
        public string token { get; } = DiscordPlayerCountBot_Exiled8.Config.BotToken;

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted += EventHandler.RoundStart;
            Exiled.Events.Handlers.Player.Joined += EventHandler.PlayerJoin;
            Exiled.Events.Handlers.Player.Left += EventHandler.PlayerLeave;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandler.RoundStart;
            Exiled.Events.Handlers.Player.Joined -= EventHandler.PlayerJoin;
            Exiled.Events.Handlers.Player.Left -= EventHandler.PlayerLeave;
            base.OnDisabled();
        }
    }
}