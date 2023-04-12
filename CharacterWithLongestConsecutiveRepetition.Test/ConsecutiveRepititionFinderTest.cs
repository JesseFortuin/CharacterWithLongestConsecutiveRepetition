using CharacterWithLongestConsecutiveRepetition.BL;
using Xunit;

namespace CharacterWithLongestConsecutiveRepetition.Test
{
    public class ConsecutiveRepititionFinderTest
    {
        [Fact]
        public void LongestRepetitionTest()
        {
            //arrange
            IConsecutiveRepititionFinder finder = new ConsecutiveRepititionFinder();

            var input = "aaaabb";
            
            Tuple<char?, int> result = new Tuple<char?, int>('a', 4);

            //act
            Tuple<char?, int> actual = finder.LongestRepetition(input);

            //assert
            Assert.Equal(actual, result);
        }
        [Fact]
        public void LongestRepetitionTest2()
        {
            //arrange
            IConsecutiveRepititionFinder finder = new ConsecutiveRepititionFinder();

            var input = "bbbaaabaaaa";

            Tuple<char?, int> result = new Tuple<char?, int>('a', 4);

            //act
            Tuple<char?, int> actual = finder.LongestRepetition(input);

            //assert
            Assert.Equal(result, actual);
        }
        [Fact]
        public void LongestRepetitionTestAtStart()
        {
            //arrange
            IConsecutiveRepititionFinder finder = new ConsecutiveRepititionFinder();

            var input = "abbbbb";

            Tuple<char?, int> result = new Tuple<char?, int>('b', 5);

            //act
            Tuple<char?, int> actual = finder.LongestRepetition(input);

            //assert
            Assert.Equal(result, actual);
        }
        [Fact]
        public void LongestRepetitionTest3()
        {
            //arrange
            IConsecutiveRepititionFinder finder = new ConsecutiveRepititionFinder();

            var input = "";

            Tuple<char?, int> result = new Tuple<char?, int>(null, 0);

            //act
            Tuple<char?, int> actual = finder.LongestRepetition(input);

            //assert
            Assert.Equal(actual, result);
        }
        [Fact]
        public void LongestRepetitionTest4()
        {
            //arrange
            IConsecutiveRepititionFinder finder = new ConsecutiveRepititionFinder();

            var input = "cbdeuuu900";

            Tuple<char?, int> result = new Tuple<char?, int>('u', 3);

            //act
            Tuple<char?, int> actual = finder.LongestRepetition(input);

            //assert
            Assert.Equal(actual, result);
        }
    }
}