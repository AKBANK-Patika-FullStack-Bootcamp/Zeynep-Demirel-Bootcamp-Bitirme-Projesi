using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dto
{
    public class DuesUserDto
    {
        public string user { get; set; }
        public int price { get; set; }
        public DateTime monthly { get; set; }
        public string duesDesc { get; set; }
        public bool isPaid { get; set; }
    }
}
