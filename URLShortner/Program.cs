using System.Transactions;

Dictionary<string, string> urld = new Dictionary<string, string>();
while (true)
{
    Console.WriteLine("\n1.UrlShorten. \n2.Get Original Url \n3.Exit");
    Console.WriteLine("Enter your choise");
    string choice = Console.ReadLine() ?? " ";
    if (choice == "1")
    {
        Console.WriteLine("Enter your Url");
        string longUrl = Console.ReadLine() ?? " ";
        if (string.IsNullOrWhiteSpace(longUrl))
        {
            Console.WriteLine("Invalid Url");
            continue;
        }
        string shortcode = GenerateShortCode();
        urld[shortcode] = longUrl;
        Console.WriteLine("Short URl Code : " + shortcode);
    }
    else if (choice == "2")
    {
        Console.Write("Enter Short Code: ");
        string code = Console.ReadLine() ?? " ";
        if (urld.ContainsKey(code))
        {
            Console.WriteLine("Original URL: " + urld[code]);
        }
        else
        {
            Console.WriteLine("URL not found.");
        }
    }
    else if (choice == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid option.");
    }
}
static string GenerateShortCode()
{
    string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    Random random = new Random();

    string shortcode = "";
    for (int i = 0; i < 6; i++)
    {
        int index = random.Next(chars.Length);
        shortcode += chars[index];
    }
    return shortcode;
}
