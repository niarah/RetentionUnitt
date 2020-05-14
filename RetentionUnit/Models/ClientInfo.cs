using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace RetentionUnit.Models
{
    public class ClientInfo
    {
        public long clientIbsoId { get; set; }
        public string birthDate { get; set; }
        public string birthPlace { get; set; }
        public string fullName { get; set; }
        public string docSeriesNum { get; set; }
        public string clntPhone { get; set; }
        public string errorMessage { get; set; }

    }
}
