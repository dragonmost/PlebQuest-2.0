namespace PlebQuest2.Utils;

internal static class Extensions
{
    public static bool NextBool(this Random random) => random.Next() % 2 == 0;
    public static IEnumerable<T> NotNull<T>(this IEnumerable<T?> enumerable) => enumerable.Where(v => v is not null)!;

    public static T GetRandom<T>(this T[] enumerable) => enumerable.ElementAt(Random.Shared.Next(enumerable.Length));

    public static IEnumerable<(T1, T2)> Combine<T1, T2>(this IEnumerable<T1> t1, IEnumerable<T2> t2) =>
        t1.SelectMany(i =>
        t2.Select(j => (i, j)));

    public static IEnumerable<(T1, T2, T3)> Combine<T1, T2, T3>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3) => 
        t1.SelectMany(i => 
        t2.SelectMany(j => 
        t3.Select(k => (i, j, k))));

    public static IEnumerable<(T1, T2, T3, T4)> Combine<T1, T2, T3, T4>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4) =>
        t1.SelectMany(i =>
        t2.SelectMany(j =>
        t3.SelectMany(k => 
        t4.Select(l => (i, j, k, l)))));
}
