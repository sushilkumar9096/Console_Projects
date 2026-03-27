namespace UnitConvertor

{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1. KM to Miles");
            Console.WriteLine("2. Miles to KM");
            Console.WriteLine("3. KG to Pounds");
            Console.WriteLine("4. Pounds to KG");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value: ");
            double value = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Miles: " + (value * 0.621));
            }
            else if (choice == 2)
            {
                Console.WriteLine("KM: " + (value / 0.621));
            }
            else if (choice == 3)
            {
                Console.WriteLine("Pounds: " + (value * 2.2));
            }
            else if (choice == 4)
            {
                Console.WriteLine("KG: " + (value / 2.2));
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

    }
}
