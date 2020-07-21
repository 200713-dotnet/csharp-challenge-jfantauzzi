using System;

namespace Palindrome.Domain.Models
{
  public class Palindrome
  {
    public bool IsPalindrome(string input)
    {
      char[] charInput = input.ToCharArray();

      Array.Reverse(charInput);
      string reverse = new string(charInput);

      bool bo = input.Equals(reverse, StringComparison.OrdinalIgnoreCase);

      return bo;

    }
  }
}