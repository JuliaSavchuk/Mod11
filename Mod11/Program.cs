namespace Mod11
{
    internal class Program
    {
        static void Main()
        {
            Store store1 = new Store("Grocery Mart", "123 Main St", "продовольчий");
            store1.DisplayInfo();
            store1.Dispose();

            Store store2 = new Store("Clothing Boutique", "456 High St", "одяг");
            store2.DisplayInfo();
            store2 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }

}
