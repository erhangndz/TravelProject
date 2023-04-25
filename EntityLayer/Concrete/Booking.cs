using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string   Name  { get; set; }
        public string   Email  { get; set; }
        public DateTime   date  { get; set; }
        public string Message { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
