namespace Mod11
{
    public class Store : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string StoreType { get; set; }

        public Store(string name, string address, string storeType)
        {
            Name = name;
            Address = address;
            StoreType = storeType;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Store Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Type: {StoreType}");
        }

        public void Dispose()
        {
            Console.WriteLine($"The store '{Name}' is being disposed.");
            GC.SuppressFinalize(this);
        }

        ~Store()
        {
            Dispose();
        }
    }
}
