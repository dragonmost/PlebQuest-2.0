using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace PlebQuest2.Utils;

internal struct ImmutableValueArray<T> : IEnumerable<T>
{
    private readonly ImmutableArray<T> values;

    public int Length => values.Length;

    public T this[int index] => values[index];

    public ImmutableValueArray(params T[] values)
        : this(values as IEnumerable<T>)
    {
    }

    public ImmutableValueArray(IEnumerable<T> values)
    {
        this.values = values.ToImmutableArray();
    }

    public override string ToString()
    {
        return $"{typeof(T).Name}[] {{ {string.Join(", ", values)} }}";
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        if (obj is not IEnumerable<T> enumerable)
        {
            return false;
        }

        return Enumerable.SequenceEqual(this, enumerable);
    }

    public override int GetHashCode()
    {
        HashCode hashCode = new();

        foreach (var value in values)
        {
            hashCode.Add(value);
        }

        return hashCode.ToHashCode();
    }

    public IEnumerator<T> GetEnumerator() => (values as IEnumerable<T>).GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public static implicit operator ImmutableValueArray<T>(T[]? array) => new ImmutableValueArray<T>(array ?? new T[0]);
    public static implicit operator ImmutableValueArray<T>(ImmutableArray<T> array) => new ImmutableValueArray<T>(array);
}
