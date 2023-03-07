using System.Reflection;

namespace PlebQuest2.Utils;

internal static class RecordEnumUtil
{
    public static T[] GetAll<T>()
    {
        return Storage<T>.Values ??= FindAll<T>().ToArray();
    }

    private static IEnumerable<T> FindAll<T>()
    {
        return typeof(T)
            .GetMembers(BindingFlags.GetProperty | BindingFlags.GetField | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
            .Select(t => t switch
            {
                PropertyInfo p => p.GetValue(null),
                FieldInfo i => i.GetValue(null),
                _ => null
            })
            .OfType<T>();
    }

    private static class Storage<T>
    {
        public static T[]? Values;
    }
}
