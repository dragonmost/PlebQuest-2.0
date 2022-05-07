internal record EntityEquipment
{
    private ImmutableArray<IEquipmentSlot> allSlots;

    public EquipmentSlots<Bracelet> LeftWristBracelets { get; } = new(5);
    public EquipmentSlots<Bracelet> RightWristBracelets { get; } = new(5);

    public EquipmentSlots<Bracelet> LeftAnkleBracelets { get; } = new(5);
    public EquipmentSlots<Bracelet> RightAnkleBracelets { get; } = new(5);

    public EquipmentSlots<Earring> LeftEarrings { get; } = new(10);
    public EquipmentSlots<Earring> RightEarrings { get; } = new(10);

    public EquipmentSlot<Glove> LeftGlove { get; } = new();
    public EquipmentSlot<Glove> RightGlove { get; } = new();

    public EquipmentSlot<Item> LeftHand { get; } = new();
    public EquipmentSlot<Item> RightHand { get; } = new();

    public EquipmentSlot<Boot> LeftBoot { get; } = new();
    public EquipmentSlot<Boot> RightBoot { get; } = new();

    public EquipmentSlot<Helmet> Helmet { get; } = new();
    public EquipmentSlot<ArmorPiece> ArmorPiece { get; } = new();
    public EquipmentSlot<Pants> Pants { get; } = new();

    public EquipmentSlots<Amulet> Amulets { get; } = new(5);

    public EquipmentSlots<Ring> LeftPinkyRings { get; } = new(3);
    public EquipmentSlots<Ring> LeftRingFingerRings { get; } = new(4);
    public EquipmentSlots<Ring> LeftMiddleFingerRings { get; } = new(5);
    public EquipmentSlots<Ring> LeftIndexFingerRings { get; } = new(4);
    public EquipmentSlots<Ring> LeftThumbRings { get; } = new(2);

    public EquipmentSlots<Ring> RightPinkyRings { get; } = new(3);
    public EquipmentSlots<Ring> RightRingFingerRings { get; } = new(4);
    public EquipmentSlots<Ring> RightMiddleFingerRings { get; } = new(5);
    public EquipmentSlots<Ring> RightIndexFingerRings { get; } = new(4);
    public EquipmentSlots<Ring> RightThumbRings { get; } = new(2);

    public EntityEquipment()
    {
        var properties = GetType().GetProperties().Select(p => p.GetValue(this));

        allSlots = properties
            .OfType<IEquipmentSlots>()
            .SelectMany(s => s.Slots)
            .Concat(properties.OfType<IEquipmentSlot>())
            .ToImmutableArray();
    }

    public Stats GetTotalStats()
    {
        return allSlots
            .Select(s => s.Item)
            .NotNull()
            .Select(i => i.Stats)
            .Aggregate(new Stats(), (a, b) => a + b);
    }
}
