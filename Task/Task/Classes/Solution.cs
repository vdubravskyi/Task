namespace Task.Classes
{
    public class Solution
    {
        public string GetSolution(string s, string t)
        {
            if (s.Length - t.Length < -1 || s.Length > t.Length)
            {
                return "IMPOSSIBLE";
            }

            if (s.Equals(t))
            {
                return "EQUAL";
            }

            if (s.Length - t.Length == -1)
            {
                var isStringsHasNotRelevantChars = false;

                var insertingValue = ' ';

                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] != t[i])
                    {
                        if (isStringsHasNotRelevantChars && s.Substring(i) != t.Substring(i + 1))
                        {
                            return "IMPOSSIBLE";
                        }

                        if (!isStringsHasNotRelevantChars)
                        {
                            insertingValue = t[i];

                            isStringsHasNotRelevantChars = true;
                        }
                    }
                }

                return $"INSERT {insertingValue}";
            }
            else
            {
                var isStringsHasNotRelevantChars = false;

                var replaceWith = ' ';
                var shouldBeReplaced = ' ';

                var firstNotRelevantChar = ' ';

                for (var i = 0; i < t.Length; i++)
                {
                    if (s[i] != t[i])
                    {
                        if (isStringsHasNotRelevantChars)
                        {
                            if (firstNotRelevantChar == s[i] &&
                                (s.Substring(i + 1) == t.Substring(i + 1) || t.Length == i - 1))
                            {
                                return $"SWAP {t[i]} {firstNotRelevantChar}";
                            }

                            return "IMPOSSIBLE";
                        }

                        firstNotRelevantChar = t[i];

                        shouldBeReplaced = s[i];
                        replaceWith = t[i];

                        isStringsHasNotRelevantChars = true;
                    }
                }

                return $"REPLACE {shouldBeReplaced} {replaceWith}";
            }
        }
    }
}
