namespace ConsoleApp1
{
    public class Car
    {
        public Car(string manufactorer, string brand, string model)
        {
            Manufactorer = manufactorer;
            Brand = brand;
            Model = model;
        }

        public string Manufactorer { get; }
        public string Brand { get; }
        public string Model { get; }

        public override string ToString()
        {
            return $"{Model}, made by: {Manufactorer}";
        }
    }
}