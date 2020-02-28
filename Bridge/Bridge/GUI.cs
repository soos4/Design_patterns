using System;
namespace Bridge
{
    public abstract class GUI
    {
        protected OS os;

        protected string guiType;

        public string GetInfo()
        {
            return guiType + " on " + os.GetOSInfo();
        }
    }
}
