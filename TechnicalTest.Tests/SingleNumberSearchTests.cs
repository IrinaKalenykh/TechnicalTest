using TechnicalTest.Problems;

namespace TechnicalTest.Tests
{
    [TestFixture]
    public class SingleNumberSearchTests
    {
        [TestCase(new int [] { 2, 2, 1 }, 1, 
            TestName = "GetSingleNumberViaDictionary_ReturnsNumber1")]
        [TestCase(new int [] { 4, 1, 2, 1, 2 }, 4, 
            TestName = "GetSingleNumberViaDictionary_ReturnsNumber4")]
        [TestCase(new int [] { 1 }, 1, 
            TestName = "GetSingleNumberViaDictionary_WithOneItem_ReturnsNumber1")]
        public void GetSingleNumberViaDictionary_ArrayWithSingleNumber(int[] nums, 
            int expectedResult)
        {
            var result = SingleNumberSearch.GetSingleNumberViaDictionary(nums);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(new int [] { 2, 2, 1 }, 1, 
            TestName = "GetSingleNumberViaXor_ReturnsNumber1")]
        [TestCase(new int [] { 4, 1, 2, 1, 2 }, 4, 
            TestName = "GetSingleNumberViaXor_ReturnsNumber4")]
        [TestCase(new int [] { 1 }, 1, 
            TestName = "GetSingleNumberViaXor_WithOneItem_ReturnsNumber1")]
        public void GetSingleNumberViaXor_ArrayWithSingleNumber(int[] nums, 
            int expectedResult)
        {
            var result = SingleNumberSearch.GetSingleNumberViaXor(nums);
            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}