using System;
namespace Command
{
    public class Light
    {
        private int intensity;

        public Light(int intensity)
        {
            this.intensity = intensity;
        }

        public void SetIntensity(int intensity)
        {
            this.intensity = intensity;
            Console.WriteLine("Intensitiy set to " + this.intensity);
        }

        public int GetIntensity()
        {
            return this.intensity;
        }
    }
}
