namespace Embrace.Palindrome.BlazorApp.Data
{
    public class PalindromeService
    {
        public string Generate(int min, int max)
        {
            Random random = new Random();
            char[] charArray = new char[random.Next(min, max)];
            int begin = 0, end = charArray.Length - 1;
            while(begin <= end)
            {
                char c = (char)(random.Next(26) + 'a');
                charArray[begin] = c;
                charArray[end] = c;
                begin++; end--;
            }
            return new string(charArray);
        }
    }
}
