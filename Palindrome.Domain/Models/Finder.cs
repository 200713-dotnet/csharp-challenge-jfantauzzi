namespace Palindrome.Domain.Models
{
  public class Finder
  {
    public IsPalindrome(string input)
    {
      char[] charInput = input.ToCharArray();
      
      Array.Reverse(charInput);
      string reverse = charInput;

      bool value = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);

      if (value == true)
      {
          System.Console.WriteLine("Palindrome.");
      }
      else{
          System.Console.WriteLine("Not a palindrome...");
      }

    }
  }
  }
}