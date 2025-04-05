using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    internal class Testimonial
    {
        public int TestimonialID { get; set; }
        public int Name  { get; set; }
        public int Title { get; set; }
        public int Commend { get; set; }
        public int ImageUrl { get; set; }
    }
}
