using System.Text.Json;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Write Text File");
            Console.WriteLine("2. Read Text File");
            Console.WriteLine("3. Write JSON File");
            Console.WriteLine("4. Read JSON File");
            Console.WriteLine("5. Write XML File");
            Console.WriteLine("6. Read XML File");
            Console.WriteLine("7. Exit");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                Console.Write("Enter text to save: ");
                string text = Console.ReadLine() ?? "";

                File.WriteAllText("data.txt", text);
                Console.WriteLine("Text saved successfully.");
            }

            else if (choice == "2")
            {
                if (File.Exists("data.txt"))
                {
                    string text = File.ReadAllText("data.txt");
                    Console.WriteLine("File Content: " + text);
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }

            else if (choice == "3")
            {
                var person = new
                {
                    Name = "Sushil",
                    Age = 23
                };

                string json = JsonSerializer.Serialize(person);

                File.WriteAllText("person.json", json);

                Console.WriteLine("JSON file created.");
            }

            else if (choice == "4")
            {
                if (File.Exists("person.json"))
                {
                    string json = File.ReadAllText("person.json");
                    Console.WriteLine("JSON Data: " + json);
                }
                else
                {
                    Console.WriteLine("JSON file not found.");
                }
            }

            else if (choice == "5")
            {
                XDocument doc = new XDocument(
                    new XElement("Person",
                        new XElement("Name", "Sushil"),
                        new XElement("Age", "23")
                    )
                );

                doc.Save("person.xml");

                Console.WriteLine("XML file created.");
            }

            else if (choice == "6")
            {
                if (File.Exists("person.xml"))
                {
                    string xml = File.ReadAllText("person.xml");
                    Console.WriteLine("XML Data:\n" + xml);
                }
                else
                {
                    Console.WriteLine("XML file not found.");
                }
            }

            else if (choice == "7")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}