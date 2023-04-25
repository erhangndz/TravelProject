using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Package
    {
        public int PackageID { get; set; }
        public string CountryName { get; set; }
        public string PackageDescription { get; set; }
        public string Duration { get; set; }
        public string PersonNumber { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
    }
}
