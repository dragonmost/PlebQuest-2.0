internal record EquipmentSlot<T> : IEquipmentSlot
    where T : Item
{
    public T? Item { get; set; }

    Item? IEquipmentSlot.Item => Item;
}
