using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public int Descrition { get; set; }
        public int IconUrl { get; set; }
    }
}
