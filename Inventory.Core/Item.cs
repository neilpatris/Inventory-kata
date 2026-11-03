// ===== NAMESPACE =====
namespace Inventory.Core
{
    // ===== RECORD =====
    public record Item
    {
        // ===== FIELDS =====
        public string Name => _name;
        public int BaseValue => _baseValue;
        public int Weight => _weight;

        private string _name;
        private int _baseValue;
        private int _weight;

        // ===== FUNCTIONS =====
        public Item(string name, int baseValue, int weight)
        {
            _name = name;
            _baseValue = baseValue;
            _weight = weight;
        }

        public virtual int GetValue()
        {
            return _baseValue;
        }

        public string Describe()
        {
            return Name;
        }
    }
}