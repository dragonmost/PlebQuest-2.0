namespace PlebQuest2.Items;

internal record ChestPiece(string Name, SolidMaterial Material) : Equipment(Name, Material);
