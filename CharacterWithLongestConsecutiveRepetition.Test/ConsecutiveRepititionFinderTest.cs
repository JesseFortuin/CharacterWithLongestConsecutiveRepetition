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
        [Fact]
        public void Length500Test()
        {
            //arrange
            IConsecutiveRepititionFinder finder = new ConsecutiveRepititionFinder();

            var input = "gQltr6fsKsaPuNg5t4oPTZrWqyvNFVYR91F5WfwPblcLxvOahfGAQgr9ei4zdbEQZJcgSw35WLrTfqJz6ClWanzgfEmsxNl6syNfoBRJUs0n9TPKB0gcC5Z0Gmrk0Shwazf2i8x126yzSqRlSTJ3KsITlnKhQZurkc88HpbHFegBtVq3MSK8v0onq04ZQWjscqWR02mhDd8v0bl0FP5LkgJwnrbSPlfdNSr3zILdlDDrgRpfi4WO66SvgrIFAalIc5vUHyRQraGVSzHgV3MZm1ehDbGmTLZIGRfmL5a78wnzYBQahPho8myHVHBQ1vKBKgaTZ96pHOz6x8pHW1IKkcbjGD2k7Yt86PK37CEYit9IrwXJ7DTPUGCNZG8xzkrRhYphOJGKaM2WazHILYZkjKIAawNUPyPAsf9gQSgpovql1uifQvnMtO1j4MINYPLBvzRXrSu3J51YMuF7EyZViLOkFkMn5HlUz5bZZqpWm3rpUm6T4CVt";

            Tuple<char?, int> result = new Tuple<char?, int>('8', 2);

            //act
            Tuple<char?, int> actual = finder.LongestRepetition(input);

            //assert
            Assert.Equal(result, actual);
        }
        [Fact]
        public void aabbaa()
        {
            IConsecutiveRepititionFinder finder = new ConsecutiveRepititionFinder();

            var input = "aabbccDDzz";

            Tuple<char?, int> result = new Tuple<char?, int>('a', 2);

            Tuple<char?, int> actual = finder.LongestRepetition(input);

            Assert.Equal(result, actual);

        }

    }
}