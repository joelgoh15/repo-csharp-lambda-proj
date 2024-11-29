using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n");Console.WriteLine();Console.Write(Environment.NewLine);
            ClassShoeInventory classShoeInventory = new ClassShoeInventory();
            classShoeInventory.GetShoeInventoryTable();
            classShoeInventory.GetShoeInventoryTableOrderByShoeSizeDescending();
            classShoeInventory.GetShoeInventoryTableById(3);
            classShoeInventory.GetShoeInventoryTableFilterByShoeSize(45);
            classShoeInventory.GetShoeInventoryTableFilterByShoeSize(50);
            classShoeInventory.GetShoeInventoryTableFilterByShoeSizeRange(3, 12);
            classShoeInventory.GetShoeInventoryTableFilterByShoeQuantity(12);
            Console.ReadLine();
        }
    }
}
