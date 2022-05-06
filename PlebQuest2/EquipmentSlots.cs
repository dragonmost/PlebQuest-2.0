internal record EquipmentSlots
{
    public ItemType ItemTypes { get; }
    public int Count { get; }

    public ImmutableArray<EquipmentSlot> Slots { get; }

    public EquipmentSlot this[int index] => Slots[index];

    public EquipmentSlots(ItemType itemTypes, int count)
    {
        ItemTypes = itemTypes;
        Count = count;

        Slots = Enumerable.Range(0, count).Select(_ => new EquipmentSlot(itemTypes)).ToImmutableArray();
    }
}
