using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string NameSurname { get; set; }
        public string City { get; set; }
        public string Comment { get; set; }
        public string ImageURL { get; set; }
    }
}
