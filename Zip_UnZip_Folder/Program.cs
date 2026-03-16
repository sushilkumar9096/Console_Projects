using System.IO.Compression;

namespace Zip_UnZip_Folder
{

    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1. Zip Folder");
                Console.WriteLine("2. Unzip File");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    Console.Write("Enter folder path to zip: ");
                    string source = Console.ReadLine() ?? "";

                    Console.Write("Enter zip file path: ");
                    string destination = Console.ReadLine() ?? "";

                    try
                    {
                        ZipFile.CreateFromDirectory(source, destination);
                        Console.WriteLine("Folder zipped successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter zip file path: ");
                    string zipPath = Console.ReadLine() ?? "";

                    Console.Write("Enter destination folder: ");
                    string extractPath = Console.ReadLine() ?? "";

                    try
                    {
                        ZipFile.ExtractToDirectory(zipPath, extractPath);
                        Console.WriteLine("Files extracted successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}
