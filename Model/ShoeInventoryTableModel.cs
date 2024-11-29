using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project10_1.Model
{
    internal class ShoeInventoryTableModel
    {
        public int Id { get; set; }
        public string ShoeName { get; set; }
        public string ShoeDescription { get; set; }
        public string ShoePrice { get; set; }
        public int ShoeSize { get; set; }
        public int ShoeQuantity { get; set; }

    }//end-class
}//end-namespace
