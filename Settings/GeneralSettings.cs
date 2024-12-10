namespace LuckyFishing;

public partial class Settings {
    // Declare as static for reflection purposes
    internal static Setting<bool> AffectJunkChance = new("General",
        "AffectJunkChance",
        true,
        "LUC reduces the chance of junk");
}