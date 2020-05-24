namespace ConsoleApp1
{
    public class Car
    {
        public string Manufactorer { get; }
        public string Model { get; }

        public Car(string manufactorer, string model)
        {
            Manufactorer = manufactorer;
            Model = model;
        }

        public override string ToString() => $"{Model}, made by: {Manufactorer}";
    }
}