namespace CharacterWithLongestConsecutiveRepetition.BL
{
    public class ConsecutiveRepititionFinder : IConsecutiveRepititionFinder
    {
        public Tuple<char?, int> LongestRepetition(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                char maxChar = input[0];

                int maxCount = 1;

                int currentCount = 1;

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == input[i - 1])
                    {
                        currentCount++;
                    }

                    else
                    {

                        if (currentCount == maxCount)
                        {
                            maxChar = input[i - 1];

                            currentCount = 1;
                        }

                        if (currentCount >= maxCount)
                        {
                            maxChar = input[i - 1];

                            maxCount = currentCount;

                            currentCount = 1;
                        }
                    }

                    if (currentCount >= maxCount)
                    {
                        maxCount = currentCount;
                    }
                }

                return new Tuple<char?, int>(maxChar, maxCount);
            }

            return new Tuple<char?, int>(null, 0);
        }
    }
}