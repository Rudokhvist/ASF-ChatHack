using System;
using System.Composition;
using ArchiSteamFarm;
using ArchiSteamFarm.Plugins;
using JetBrains.Annotations;

namespace ASF_ChatHack {
    [Export(typeof(IPlugin))]
	public sealed class ASFChatHack: IBotHackNewChat {

        public string Name => nameof(ASFChatHack);
        public Version Version => typeof(ASFChatHack).Assembly.GetName().Version;

		public bool BotUsesNewChat([NotNull] Bot bot) => bot.BotConfig.OnlineStatus!=0;

		public void OnLoaded() {
            ASF.ArchiLogger.LogGenericInfo("ASF-ChatHack Plugin by Ryzhehvost, powered by ginger cats");
        }
    }
}
