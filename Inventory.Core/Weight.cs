// ===== NAMESPACE =====
namespace Inventory.Core
{
    // ===== STRUCT ===== 
    public readonly struct Weight
    {
        // ===== FIELDS =====
        public int Amount => _weight;
        private readonly int _weight;
        
        // ==== FUNCTIONS ====
        public Weight(int weight)
        {
            _weight = weight;
        }

        public static Weight operator +(Weight weight1, Weight weight2)
        {
            return new Weight(weight1.Amount + weight2.Amount);
        }

        public static bool operator ==(Weight weight1, Weight weight2)
        {
            return weight1.Equals(weight2);
        }

        public static bool operator !=(Weight weight1, Weight weight2)
        {
            return !weight1.Equals(weight2);
        }

        public override bool Equals(object? obj)
        {
            return obj is Weight other && _weight == other.Amount;
        }

        public override int GetHashCode()
        {
            return _weight.GetHashCode();
        }
    }
}
