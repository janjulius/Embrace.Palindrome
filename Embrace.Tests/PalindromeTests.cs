using Embrace.Palindrome.BlazorApp.Data;
using Xunit;

namespace Embrace.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void IsPalindrome()
        {
            //arrange
            PalindromeService service = new();
            Random random= new Random();
            int min = 2, max = random.Next(2, 100);

            //act
            var palindrome = service.Generate(min, max);
            var reverse = new string(palindrome.Reverse().ToArray());

            //assert
            Assert.True(palindrome == reverse);
        }
    }
}