namespace Embrace.Palindrome.BlazorApp.Data
{
    public class PalindromeService
    {
        public string Generate(int min, int max)
        {
            Random random = new Random();
            char[] a = new char[random.Next(min, max)];
            int begin = 0, end = a.Length - 1;
            while(begin <= end)
            {
                char c = (char)(random.Next(26) + 'a');
                a[begin] = c;
                a[end] = c;
                begin++; end--;
            }
            return new string(a);
        }
    }
}
