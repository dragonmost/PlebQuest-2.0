using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    internal static class Extensions
    {
        public static T Next<T>(this Random random, params T[] exclusions) where T : unmanaged, Enum
        {
            T[] values = Enum.GetValues<T>().Where(v => !exclusions.Contains(v)).ToArray();

            return values[random.Next() % values.Length];
        }
    }
}
