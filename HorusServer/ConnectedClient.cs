using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorusServer
{
    class ConnectedClient
    {
        private string Client;

        public ConnectedClient(string Client)
        {
            this.Client = Client;
        }

        public string GetClientAddress()
        {
            return this.Client;
        }

    }
}
