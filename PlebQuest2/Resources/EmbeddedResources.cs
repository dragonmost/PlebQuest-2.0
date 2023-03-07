using System.Drawing;
using System.Reflection;

namespace PlebQuest2.Resources;

internal class EmbeddedResources
{
    public static Bitmap LoadImage(string name, Assembly? assembly = default)
    {
        assembly ??= Assembly.GetCallingAssembly();

        var stream = assembly.GetManifestResourceStream(name) ?? throw new Exception($"Failed to load embedded resource \"{name}\"");

        return new Bitmap(stream);
    }
}
