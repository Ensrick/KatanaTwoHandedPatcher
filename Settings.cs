namespace KatanaTwoHandedPatcher;

public sealed class Settings
{
    public float Speed { get; set; } = 0.85f;
    public float Reach { get; set; } = 1.20f;
    public float Stagger { get; set; } = 0.90f;

    // FormKeys use Mutagen's "FormID:PluginName" notation.
    public List<string> ForceInclude { get; set; } = [];
    public List<string> Exclude { get; set; } = [];
}
