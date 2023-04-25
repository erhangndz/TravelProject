using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }
        public int DiscountRate { get; set; }
        public string ImageURL { get; set; }
        public List<Destination> Destinations { get; set;}

    }
}
