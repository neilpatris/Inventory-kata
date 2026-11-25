// ===== NAMESPACE =====
namespace Inventory.Core
{
    // ===== RECORD =====
    public record Potion : Item
    {
        // ===== FUNCTIONS =====
        public Potion(string name, int baseValue, int weight)
        : base(name, baseValue, weight)
        {
        }
    }
}
