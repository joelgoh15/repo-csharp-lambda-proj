using project10_1.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace project10_1
{
    internal class ClassShoeInventory
    {
        App_Data.ShoeInventoryDBDataClassesDataContext shoeInventoryDBDataClassesDataContext = new App_Data.ShoeInventoryDBDataClassesDataContext();    

        public void GetShoeInventoryTable()
        {
             
            Console.WriteLine("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", "Id",
                "ShoeName", "ShoeDescription", "ShoePrice", "ShoeSize", "Quantitiy" );

            Console.WriteLine("--------------------------------------------------------------------");

            var shoeInventoryModel = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).ToList();


            if (shoeInventoryModel.Count > 0)
            {
                foreach (var item in shoeInventoryModel)
                {
                    Console.Write("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", item.Id, item.ShoeName, item.ShoeDescription, item.ShoePrice, item.ShoeSize, item.ShoeQuantity);
                    Console.WriteLine();
                }
            } else {
                Console.WriteLine("No data in table to display.");
            }
        }


        public void GetShoeInventoryTableOrderByShoeSizeDescending()
        {

            Console.WriteLine("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", "Id",
                "ShoeName", "ShoeDescription", "ShoePrice", "ShoeSize", "Quantitiy");

            Console.WriteLine("--------------------------------------------------------------------");

            var shoeInventoryModel = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).OrderByDescending(x => x.ShoeSize).ToList();


            if (shoeInventoryModel.Count > 0)
            {
                foreach (var item in shoeInventoryModel)
                {
                    Console.Write("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", item.Id, item.ShoeName, item.ShoeDescription, item.ShoePrice, item.ShoeSize, item.ShoeQuantity);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No data in table to display.");
            }
        }

        public void GetShoeInventoryTableById(int id)
        {
            Console.WriteLine("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", "Id",
                "ShoeName", "ShoeDescription", "ShoePrice", "ShoeSize", "Quantitiy");

            Console.WriteLine("--------------------------------------------------------------------");

            var shoeInventoryModel = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).Where(x => x.Id == id).FirstOrDefault();

            if (shoeInventoryModel == null)
            {
                Console.WriteLine("shoe id do not exist.");

            } else {
                Console.Write("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", shoeInventoryModel.Id, shoeInventoryModel.ShoeName, shoeInventoryModel.ShoeDescription, shoeInventoryModel.ShoePrice, shoeInventoryModel.ShoeSize, shoeInventoryModel.ShoeQuantity);
                Console.WriteLine();
            }
        }

        public void GetShoeInventoryTableFilterByShoeSize(int minShoeSize)
        {
            Console.WriteLine("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", "Id",
                "ShoeName", "ShoeDescription", "ShoePrice", "ShoeSize", "Quantitiy");

            Console.WriteLine("--------------------------------------------------------------------");

            var shoeInventoryModel = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).Where(x => x.ShoeSize >= minShoeSize).ToList();

            if (shoeInventoryModel.Count > 0)
            {
                foreach (var item in shoeInventoryModel)
                {
                    Console.Write("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", item.Id, item.ShoeName, item.ShoeDescription, item.ShoePrice, item.ShoeSize, item.ShoeQuantity);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No data in table to display.");
            }
        }

        public void GetShoeInventoryTableFilterByShoeSizeRange(int minShoeSize, int maxShoeSize)
        {
            Console.WriteLine("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", "Id",
                "ShoeName", "ShoeDescription", "ShoePrice", "ShoeSize", "Quantitiy");

            Console.WriteLine("--------------------------------------------------------------------");

            var shoeInventoryModel = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).Where(x => x.ShoeSize >= minShoeSize && x.ShoeSize <= maxShoeSize).ToList();

            if (shoeInventoryModel.Count > 0)
            {
                foreach (var item in shoeInventoryModel)
                {
                    Console.Write("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", item.Id, item.ShoeName, item.ShoeDescription, item.ShoePrice, item.ShoeSize, item.ShoeQuantity);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No data in table to display.");
            }
        }

        public void GetShoeInventoryTableFilterByShoeQuantity(int minShoeQuantity)
        {
            Console.WriteLine("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", "Id",
                "ShoeName", "ShoeDescription", "ShoePrice", "ShoeSize", "Quantitiy");

            Console.WriteLine("--------------------------------------------------------------------");

            var shoeInventoryModel = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).Where(x => x.ShoeQuantity >= minShoeQuantity).ToList();

            if (shoeInventoryModel.Count > 0)
            {
                foreach (var item in shoeInventoryModel)
                {
                    Console.Write("{0,3}{1,12}{2,22}{3,11}{4,10}{5,10}", item.Id, item.ShoeName, item.ShoeDescription, item.ShoePrice, item.ShoeSize, item.ShoeQuantity);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No data in table to display.");
            }
        }

        public void AdditionalMethodCall()
        {
            var shoeInventoryModel1 = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).Where(x => x.ShoeName.StartsWith("shoe")).FirstOrDefault();

            
            var shoeInventoryModel2 = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).Where(x => x.ShoeName.EndsWith("48")).FirstOrDefault();

            
            var shoeInventoryModel3 = shoeInventoryDBDataClassesDataContext.ShoeInventoryTables.
                Select(x => new Model.ShoeInventoryTableModel()
                {
                    Id = x.Id,
                    ShoeName = x.ShoeName,
                    ShoeDescription = x.ShoeDescription,
                    ShoePrice = x.ShoePrice,
                    ShoeSize = (int)x.ShoeSize,
                    ShoeQuantity = (int)x.Quantity
                }).OrderBy(x => x.ShoeQuantity).Take(2).ToList();

            
            IEnumerable<string> shoeNames = shoeInventoryModel3.Select(x => x.ShoeName);
            foreach (var shoeName in shoeNames)
                Console.WriteLine("{0}", shoeName);

        }

    }
}
