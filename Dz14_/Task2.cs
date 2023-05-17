using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz14_
{
    public class Shop : IDisposable
    {
        public StringBuilder title { get; set; }
        public StringBuilder address { get; set; }
        public Type type { get; set; }

        public void Show()
        {
            Console.WriteLine("\nShop information:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Type: {type}");
        }
        public void Dispose()
        {
            title.Clear();
            address.Clear();
            type = 0;
            Console.WriteLine("Object delete\n");
        }
        public Shop(string Title, string Address, string Type)
        {
            title = new StringBuilder(Title);
            address = new StringBuilder(Address);
            type = (Type)Enum.Parse(typeof(Type), Type);
            Console.WriteLine("Object create");
        }
    }
    public enum Type
    {
        Grocery,
        Hardware, 
        Clothing, 
        Shoes,
    }
}
