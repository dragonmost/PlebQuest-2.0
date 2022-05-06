internal record EquipmentSlot(ItemType ItemTypes)
{
    public Item? Item { get; private set; }
    
    public bool CanEquip(ItemType itemType) => ItemTypes.HasFlag(itemType);

    public bool TryEquip(Item? item)
    {
        if (item is null || !CanEquip(item.Type))
        {
            return false;
        }

        Item = item;
        return true;
    }
}
