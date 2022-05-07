internal class Fight
{
    public FightingEntity Attacker { get; set; }
    public FightingEntity Defender { get; set; }

    public bool Done => Attacker.Health <= 0 || Defender.Health <= 0;

    public Fight(Entity attacker, Entity defender)
    {
        Attacker = new(attacker);
        Defender = new(defender);
    }

    public string Step()
    {
        try
        {
            int damage = Attacker.Entity.GetDamage(Attacker.Entity.Equipment.RightHand.Item);

            if (damage < 0)
            {
                return $"{Attacker.Entity.Name} is too weak and does not damage to {Defender.Entity.Name}";
            }

            Defender.Health -= damage;

            if (Defender.Health <= 0)
            {
                Defender.Health = 0;
                return $"{Attacker.Entity.Name} deals {damage} damage to {Defender.Entity.Name}, killing them";
            }

            return $"{Attacker.Entity.Name} deals {damage} damage to {Defender.Entity.Name}, bringing them to {Defender.Health}";
        }
        finally
        {
            (Attacker, Defender) = (Defender, Attacker);
        }
    }

    internal record FightingEntity(Entity Entity)
    {
        public int Health { get; set; } = Entity.MaxHealth;
    }
}