using Dalamud.Data;
using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.Buddy;
using Dalamud.Game.ClientState.Conditions;
using Dalamud.Game.ClientState.JobGauge;
using Dalamud.Game.ClientState.Objects;
using Dalamud.Game.Command;
using Dalamud.Game.Gui;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace XIVComboExpandedestPlugin
{
    /// <summary>
    /// Dalamud and plugin services.
    /// </summary>
    internal class Service
    {
        /// <summary>
        /// Gets or sets the plugin configuration.
        /// </summary>
        internal static PluginConfiguration Configuration { get; set; } = null!;

        /// <summary>
        /// Gets or sets the plugin icon replacer.
        /// </summary>
        internal static IconReplacer IconReplacer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the plugin address resolver.
        /// </summary>
        internal static PluginAddressResolver Address { get; set; } = null!;

        /// <summary>
        /// Gets the Dalamud plugin interface.
        /// </summary>
        [PluginService]
        internal static IDalamudPluginInterface Interface { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud chat gui.
        /// </summary>
        [PluginService]
        internal static IChatGui ChatGui { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud client state.
        /// </summary>
        [PluginService]
        internal static IClientState ClientState { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud command manager.
        /// </summary>
        [PluginService]
        internal static ICommandManager CommandManager { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud condition.
        /// </summary>
        [PluginService]
        internal static ICondition Condition { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud data manager.
        /// </summary>
        [PluginService]
        internal static IDataManager DataManager { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud job gauges.
        /// </summary>
        [PluginService]
        internal static IJobGauges JobGauges { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud Buddy List.
        /// </summary>
        [PluginService]
        internal static IBuddyList BuddyList { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud target manager.
        /// </summary>
        [PluginService]
        internal static ITargetManager TargetManager { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud signature scanner.
        /// </summary>
        [PluginService]
        internal static ISigScanner SigScanner { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud Game Interoperation Provider.
        /// </summary>
        [PluginService]
        internal static IGameInteropProvider GameInteropProvider { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud Plugin Log.
        /// </summary>
        [PluginService]
        internal static IPluginLog PluginLog { get; private set; } = null!;
    }
}
