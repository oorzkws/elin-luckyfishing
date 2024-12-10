using BepInEx.Logging;

namespace LuckyFishing;

public static class Logging {
    internal static void Log(object payload, LogLevel level = LogLevel.Info) {
        // This doesn't error, Rider just hasn't caught up
        LuckyFishing.Logger!.Log(level, payload);
    }
}