using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionOfProject.VeiwModel
{
    public class OrderViewModel
    {
        public DateTime OrderDate { get; set; }
        public int CountItems { get; set; }
        public decimal Price { get; set; }
    }
}
