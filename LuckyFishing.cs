using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;

namespace LuckyFishing;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
internal class LuckyFishing : BaseUnityPlugin {
    internal static new ManualLogSource? Logger { get; private set; }
    // Access to settings
    public static new ConfigFile? Config { get; private set; }

    private void Awake() {
        Logger = base.Logger;
        Config = base.Config;
        _ = new Settings(Config);
        var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();
        Logging.Log($"{MyPluginInfo.PLUGIN_NAME} version {MyPluginInfo.PLUGIN_VERSION} successfully loaded", LogLevel.Message);
    }
}