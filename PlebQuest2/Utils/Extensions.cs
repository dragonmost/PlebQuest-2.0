namespace PlebQuest2.Utils;

internal static class Extensions
{
    public static bool NextBool(this Random random) => random.Next() % 2 == 0;
    public static IEnumerable<T> NotNull<T>(this IEnumerable<T?> enumerable) => enumerable.Where(v => v is not null)!;
}
