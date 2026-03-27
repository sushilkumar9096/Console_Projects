namespace FileDuplicationTool
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter folder path: ");
            string path = Console.ReadLine();

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                for (int j = i + 1; j < files.Length; j++)
                {
                    if (File.ReadAllText(files[i]) == File.ReadAllText(files[j]))
                    {
                        Console.WriteLine("Duplicate Found:");
                        Console.WriteLine(files[i]);
                        Console.WriteLine(files[j]);
                    }
                }
            }
        }
    }
}
