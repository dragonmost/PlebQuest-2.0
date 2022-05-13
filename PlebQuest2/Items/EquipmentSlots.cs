namespace PlebQuest2.Items;

internal record EquipmentSlots<T> : IEquipmentSlots
    where T : Item
{
    public int Count { get; }

    public ImmutableValueArray<EquipmentSlot<T>> Slots { get; }

    IEnumerable<IEquipmentSlot> IEquipmentSlots.Slots => Slots;

    public EquipmentSlot<T> this[int index] => Slots[index];

    public EquipmentSlots(int count)
    {
        Count = count;

        Slots = Enumerable.Range(0, count).Select(_ => new EquipmentSlot<T>()).ToImmutableArray();
    }
}
