internal record Equipment
{
    private ImmutableArray<EquipmentSlot> allSlots;

    public EquipmentSlots LeftWristBracelets { get; } = new(ItemType.Bracelet, 5);
    public EquipmentSlots RightWristBracelets { get; } = new(ItemType.Bracelet, 5);

    public EquipmentSlots LeftAnkleBracelets { get; } = new(ItemType.Bracelet, 5);
    public EquipmentSlots RightAnkleBracelets { get; } = new(ItemType.Bracelet, 5);

    public EquipmentSlots LeftEarrings { get; } = new(ItemType.Earring, 10);
    public EquipmentSlots RightEarrings { get; } = new(ItemType.Earring, 10);

    public EquipmentSlot LeftGlove { get; } = new(ItemType.Glove);
    public EquipmentSlot RightGlove { get; } = new(ItemType.Glove);

    public EquipmentSlot LeftHand { get; } = new(ItemType.All);
    public EquipmentSlot RightHand { get; } = new(ItemType.All);

    public EquipmentSlot LeftBoot { get; } = new(ItemType.Boot);
    public EquipmentSlot RightBoot { get; } = new(ItemType.Boot);

    public EquipmentSlot Helmet { get; } = new(ItemType.Helmet);
    public EquipmentSlot Armor { get; } = new(ItemType.Armor);
    public EquipmentSlot Pants { get; } = new(ItemType.Pants);

    public EquipmentSlots Amulets { get; } = new(ItemType.Amulet, 5);

    public EquipmentSlots LeftPinkyRings { get; } = new(ItemType.Ring, 3);
    public EquipmentSlots LeftRingFingerRings { get; } = new(ItemType.Ring, 4);
    public EquipmentSlots LeftMiddleFingerRings { get; } = new(ItemType.Ring, 5);
    public EquipmentSlots LeftIndexFingerRings { get; } = new(ItemType.Ring, 4);
    public EquipmentSlots LeftThumbRings { get; } = new(ItemType.Ring, 2);

    public EquipmentSlots RightPinkyRings { get; } = new(ItemType.Ring, 3);
    public EquipmentSlots RightRingFingerRings { get; } = new(ItemType.Ring, 4);
    public EquipmentSlots RightMiddleFingerRings { get; } = new(ItemType.Ring, 5);
    public EquipmentSlots RightIndexFingerRings { get; } = new(ItemType.Ring, 4);
    public EquipmentSlots RightThumbRings { get; } = new(ItemType.Ring, 2);

    public Equipment()
    {
        var properties = GetType().GetProperties().Select(p => p.GetValue(this));

        allSlots = properties
            .OfType<EquipmentSlots>()
            .SelectMany(s => s.Slots)
            .Concat(properties.OfType<EquipmentSlot>())
            .ToImmutableArray();
    }

    public Stats GetTotalStats()
    {
        return allSlots
            .Select(s => s.Item)
            .NotNull()
            .Select(i => i.BaseStats)
            .Aggregate(new Stats(), (a, b) => a + b);

    }
}
