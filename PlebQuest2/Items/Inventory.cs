using System.Collections;

namespace PlebQuest2.Items;

internal class Inventory : IEnumerable<ItemStack>
{
    private readonly Dictionary<Item, int> items = new();

    public ItemStack? Remove(Item item, int amount = int.MaxValue)
    {
        if (!items.TryGetValue(item, out int count))
        {
            return default;
        }

        int taking = Math.Min(count, amount);
        int remaining = count - taking;
        
        if (remaining > 0)
        {
            items[item] = remaining;
        }
        else
        {
            items.Remove(item);
        }

        return new ItemStack(item, taking);
    }

    public void Add(ItemStack itemStack)
    {
        if (items.TryGetValue(itemStack.Item, out int count))
        {
            items[itemStack.Item] += itemStack.Count;
        }
        else
        {
            items.Add(itemStack.Item, itemStack.Count);
        }
    }

    public int GetCount(Item item)
    {
        return items.GetValueOrDefault(item);
    }

    public IEnumerator<ItemStack> GetEnumerator() => items.Select(kv => new ItemStack(kv.Key, kv.Value)).GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

internal record ItemStack(Item Item, int Count = 1)
{
    public static implicit operator ItemStack(Item item) => new ItemStack(item);
}
