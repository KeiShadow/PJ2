using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIP
{
    public class IPAddress
    {
        public string IPC, maska;
        
        public IPAddress(string ip, string maska)
        {
            this.IPC = ip;
            this.maska = maska;
        }

        public bool IsInNetwork(string ip)
        {
            string[] pomIP = ip.Split('.');
            string[] pomIPC = IPC.Split('.');
            string[] pomMask = maska.Split('.');

            for (int i = 0; i < pomMask.Length; i++)
            {
                if (pomMask[i] == "255")
                {
                    if (pomIPC[i] != pomIP[i])
                    {
                        return false;
                    }
                } 
            }
            return true;

        }
    }
}
