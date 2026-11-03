// ===== USING =====
using Inventory.Core;
using Inventory.Core.Enums;

// ===== NAMESPACE =====
namespace Inventory.Tests
{
    // ===== CLASS =====
    [TestFixture]
    public class ItemTests
    {
        // ===== FUNCTIONS =====
        [Test]
        public void GetValue_ScalesBaseValueWithDurabilitye()
        {
            Weapon sword = new Weapon("Sword", 100, 3, 50, 25);

            Assert.That(sword.GetValue(), Is.EqualTo(50));
        }

        [Test]
        public void GetValue_ReturnsZeroWhenDurabilityIsZero()
        {
            Weapon sword = new Weapon("Sword", 100, 3, 50, 0);

            Assert.That(sword.GetValue(), Is.EqualTo(0));
        }

        [TestCase(10, Rarity.Rare, 30)]
        [TestCase(5, Rarity.Common, 5)]
        public void GetValue_MultipliesBaseValueByRarity(int baseValue, Rarity rarity, int expected)
        {
            Material material = new Material("Material", baseValue, 1, rarity);

            Assert.That(material.GetValue(), Is.EqualTo(expected));
        }

        [Test]
        public void Equals_ReturnsTrueWhenDataIsIdentical()
        {
            Potion healthPotion1 = new Potion("HealthPotion", 20, 1);
            Potion healthPotion2 = new Potion("HealthPotion", 20, 1);

            Assert.That(healthPotion1.Equals(healthPotion2), Is.EqualTo(true));
        }

        [Test]
        public void Equals_ReturnsFalseWhenDataDiffers()
        {
            Potion healthPotion = new Potion("HealthPotion", 20, 1);
            Potion manaPotion = new Potion("ManaPotion", 30, 1);

            Assert.That(healthPotion.Equals(manaPotion), Is.EqualTo(false));
        }
    }
}