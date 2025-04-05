using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Banner
    {
        public int BannerId { get; set; }
        public string Title { get; set; }
        public string Descirption { get; set; }
        public string VideoDescirption { get; set; }
        public string VideoUrl { get; set; }
    }
}
