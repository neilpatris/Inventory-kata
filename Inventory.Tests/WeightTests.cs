// ==== USING ====
using Inventory.Core;

// ===== NAMESPACE =====
namespace Inventory.Tests
{
    // ===== CLASS =====
    [TestFixture]
    public class WeightTests
    {
        [Test]
        public void AdditionOperator_ReturnsSumOfWeights()
        {
            Weight weight1 = new Weight(3);
            Weight weight2 = new Weight(2);
            Weight weightExpected = new Weight(5);

            Assert.That(weight1 + weight2, Is.EqualTo(weightExpected));
        }

        [Test]
        public void EqualityOperator_ReturnsTrueWhenWeightsAreEqual()
        {
            Weight weight1 = new Weight(2);
            Weight weight2 = new Weight(2);

            Assert.That(weight1 == weight2, Is.EqualTo(true));
        }
    }
}