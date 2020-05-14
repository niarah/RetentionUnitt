using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetentionUnit.Models
{
    public class Client
    {
        public string FullName { get; set; }
        public int Ibso { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public string BirthPlace { get; set; }
        public string Passport { get; set; }
        public string OttokReason { get; set; }
        public string OttokDesc { get; set; }
        public string StopList { get; set; }
    }
}
