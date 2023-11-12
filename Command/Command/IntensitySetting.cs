using System;

namespace Command
{
    public class IntensitySetting : Command
    {
        private Light light;

        private int previousIntensity;
        private int newInensity;

        public IntensitySetting(Light light, int intensity)
        {
            this.light = light;

            this.previousIntensity = this.light.GetIntensity();
            this.newInensity = intensity;
        }

        public void Execute()
        {
            light.SetIntensity(newInensity);
        }

        public void Undo()
        {
            light.SetIntensity(previousIntensity);
        }
    }
}