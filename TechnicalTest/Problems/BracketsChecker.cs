namespace TechnicalTest.Problems
{
    public static class BracketsChecker
    {
        public static bool IsBalancedBrackets(string expression)
        {
            var bracketsStack = new Stack<char>();
            var openingBrackets = new [] { '(', '{', '[' };

            if (expression.Length == 1)
                return false;

            for (var strIndex = 0; strIndex < expression.Length; strIndex++)
            {
                var currentBracket = expression[strIndex];

                if (openingBrackets.Contains(currentBracket))
                {
                    bracketsStack.Push(currentBracket);
                }
                else
                {
                    if (bracketsStack.Count == 0)
                        return false;

                    var previousBracket = bracketsStack.Pop();

                    switch ((previousBracket, currentBracket))
                    {
                        case ('(', ')'):
                        case ('{', '}'):
                        case ('[', ']'):
                            break;
                        default:
                            return false;
                    }
                }
            }

            return true;
        }
    }
}