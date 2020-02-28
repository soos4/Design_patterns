using System;
namespace Bridge
{
    public class ProgrammerGUI : GUI
    {
        public ProgrammerGUI(OS os)
        {
            this.guiType = "programmer GUI";
            this.os = os;
        }
    }
}
