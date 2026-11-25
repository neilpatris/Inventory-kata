// ===== NAMESPACE =====
namespace Inventory.Core
{
    // ===== RECORD =====
    public record Weapon : Item
    {
        // ===== FIELDS =====
        public int Durability => _durability;

        private int _maxDurability;
        private int _durability;

        // ===== FUNCTIONS =====
        public Weapon(string name, int baseValue, int weight, int maxDurability, int durability) 
        : base(name, baseValue, weight)
        {
            _maxDurability = maxDurability;
            _durability = durability > _maxDurability ? _maxDurability : durability;
        }

        public override int GetValue()
        {
            return BaseValue * _durability / _maxDurability;
        }

        public new string Describe()
        {
            return Name + " " + _durability + "/" + _maxDurability;
        }
    }
}
