namespace CharacterWithLongestConsecutiveRepetition.BL
{
    public interface IConsecutiveRepititionFinder
    {
        public Tuple<char?, int> LongestRepetition(string input);
    }
}