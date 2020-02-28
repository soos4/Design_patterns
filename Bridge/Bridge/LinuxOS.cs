using System;
namespace Bridge
{
    public class LinuxOS : OS
    {
        public override string GetOSInfo()
        {
            return "linux OS";
        }
    }
}
