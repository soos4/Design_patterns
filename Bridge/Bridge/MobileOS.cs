using System;
namespace Bridge
{
    public class MobileOS : OS
    {
        public override string GetOSInfo()
        {
            return "mobile OS";
        }
    }
}
