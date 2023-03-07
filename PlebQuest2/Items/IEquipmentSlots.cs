namespace PlebQuest2.Items;

internal interface IEquipmentSlots
{
    IEnumerable<IEquipmentSlot> Slots { get; }
}
