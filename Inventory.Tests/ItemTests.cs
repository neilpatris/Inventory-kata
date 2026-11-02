// ===== USING =====
using Inventory.Core;

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
    }
}