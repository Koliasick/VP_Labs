namespace VP_3
{
    public enum FuelType 
    {
        Diesel = 1,
        Benzine = 2,
        Electrycity = 4,
        Any = 7
    }

    public enum ComfortLevel 
    {
        Budget = 1,
        Comfortable = 2,
        Luxury = 4,
        Any = 7
    }

    public class CarInfo 
    {
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public float FuelConsumption { get; set; }
        public FuelType FuelType { get; set; }
        public int Reliability { get; set; }
        public ComfortLevel ComfortLevel { get; set; }
    }

    internal static class Program
    {
        public static List<CarInfo> cars = new List<CarInfo>();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}