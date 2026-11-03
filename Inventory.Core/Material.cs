// ===== USING =====
using Inventory.Core.Enums;

// ===== NAMESPACE =====
namespace Inventory.Core
{
    // ===== CLASS =====
    public class Material : Item
    {
        // ===== FIELDS =====
        private const int RareMultiplier = 3;
        private const int CommonMultiplier = 1;

        private Rarity _rarity;

        // ===== FUNCTIONS =====
        public Material(string name, int baseValue, int weight, Rarity rarity)
        : base(name, baseValue, weight)
        {
            _rarity = rarity;
        }

        public override int GetValue()
        {
            return BaseValue * GetRarityMultiplier();
        }

        private int GetRarityMultiplier()
        {
            switch (_rarity)
            {
                case Rarity.Rare: 
                    return RareMultiplier;
                case Rarity.Common: 
                    return CommonMultiplier;
                default : 
                    return 1;
            }
        }
    }
}