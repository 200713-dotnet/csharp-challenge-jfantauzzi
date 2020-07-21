using Palindrome.Domain.Models;
using Xunit;

namespace Palindrome.Testing.Tests
{
  public class FinderTest
  {
    [Theory]
    [InlineData("tacocat")]
    public void Test_Finder(string input)
    {
  
      var sut = new Palindrome.Domain.Models.Palindrome();
      var actual = sut.IsPalindrome(input);

      Assert.True(actual);
    }
  }
}