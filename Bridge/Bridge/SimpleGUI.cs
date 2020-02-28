using System;
namespace Bridge
{
    public class SimpleGUI : GUI
    {
        public SimpleGUI(OS os)
        {
            this.guiType = "simple GUI";
            this.os = os;
        }
    }
}
