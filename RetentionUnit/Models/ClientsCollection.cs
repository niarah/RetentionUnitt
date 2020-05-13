using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetentionUnit.Models
{
    public class ClientsCollection
    {
        public List<Client> Clients { get; set; }

        public ClientsCollection(Client client)
        {
            if(Clients is null)
            {
                Clients = new List<Client>();
            }
            Clients.Add(client);
        }
    }
}
