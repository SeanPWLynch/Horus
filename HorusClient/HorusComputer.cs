using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorusClient
{
    class HorusComputer
    {
        public HorusShared.ComputerObjects.Computer thisComputer;
        public HorusComputer()
        {
          thisComputer =  new HorusShared.ComputerObjects.Computer();
        }
    }
}
