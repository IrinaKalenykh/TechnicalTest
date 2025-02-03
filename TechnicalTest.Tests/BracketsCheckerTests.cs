using TechnicalTest.Problems;

namespace TechnicalTest.Tests
{
    [TestFixture]
    public class BracketsCheckerTests
    {
        [TestCase("[()]{}{[()()]()}")]
        [TestCase("{[()]}")]
        [TestCase("{{[[(())]]}}")]
        [TestCase("[]")]
        [TestCase("{}")]
        [TestCase("()")]
        public void IsBalancedBrackets_BalancedExpression_ReturnsTrue(string exp)
        {
            var result = BracketsChecker.IsBalancedBrackets(exp);
            Assert.That(result, Is.True);
        }

        [TestCase("[(])")]
        [TestCase("{[(])}")]
        [TestCase("({[]})}")]
        [TestCase("{]")]
        [TestCase("[]]")]
        [TestCase("{")]
        [TestCase(")")]
        public void IsBalancedBrackets_UnbalancedExpression_ReturnsFalse(string exp)
        {
            var result = BracketsChecker.IsBalancedBrackets(exp);
            Assert.That(result, Is.False);
        }
    }
}