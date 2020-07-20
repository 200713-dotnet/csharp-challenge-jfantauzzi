namespace Palindrome.Domain.Models
{
  public class Palindrome
  {
    public bool IsPalindrome(string input)
    {
      char[] charInput = input.ToCharArray();

      Array.Reverse(charInput);
      string reverse = new string(p);

      bool bo = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);

      return bo;

    }
  }
}