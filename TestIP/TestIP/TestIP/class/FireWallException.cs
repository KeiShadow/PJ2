using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIP
{
    public class FireWallException : Exception
    {
        public IPAddress IP { get; set; }

       public FireWallException(string ip)
        {
            IP.IPC = ip;
        }
       
    }
}
