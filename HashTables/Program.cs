using HashTables;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure - Hash Table !!! ");
        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
        Console.WriteLine("\n1.Create HashTable ");
        Console.WriteLine("Enter the option to choice from above ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Creating HashTable to find frequency of words in a sentence ");
                hash.Add("0", "To");
                hash.Add("1", "be");
                hash.Add("2", "or");
                hash.Add("3", "not");
                hash.Add("4", "to");
                hash.Add("5", "be");
                string hash0 = hash.Get("0");
                string hash1 = hash.Get("1");
                string hash2 = hash.Get("2");
                string hash3 = hash.Get("3");
                string hash4 = hash.Get("4");
                string hash5 = hash.Get("5");
                Console.WriteLine("0th index value "+ hash0);
                Console.WriteLine("1th index value " + hash1);
                Console.WriteLine("2th index value " + hash2);
                Console.WriteLine("3th index value " + hash3);
                Console.WriteLine("4th index value " + hash4);
                Console.WriteLine("5th index value " + hash5);
                break;
            default:
                Console.WriteLine("Please enter correct option ");
                break;
        }

    }
}