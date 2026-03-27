namespace PalindromChecker
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter sentence: ");
            string input = Console.ReadLine();

            string clean = "";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsLetterOrDigit(c))
                {
                    clean += char.ToLower(c);
                }
            }

            string reverse = "";

            for (int i = clean.Length - 1; i >= 0; i--)
            {
                reverse += clean[i];
            }

            if (clean == reverse)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
