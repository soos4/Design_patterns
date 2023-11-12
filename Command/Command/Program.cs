namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Light light = new Light(0);
            CommandContainer container = CommandContainer.GetInstance();

            container.StoreAndExecute(new IntensitySetting(light, 1));
            container.StoreAndExecute(new IntensitySetting(light, 3));
            container.StoreAndExecute(new IntensitySetting(light, 5));
            container.StoreAndExecute(new IntensitySetting(light, 4));
            container.StoreAndExecute(new IntensitySetting(light, 2));

            container.Undo();
            container.Undo();

            container.StoreAndExecute(new IntensitySetting(light, 7));
            container.StoreAndExecute(new IntensitySetting(light, 6));

            container.Undo();
        }
    }
}