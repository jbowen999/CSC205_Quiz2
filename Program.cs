namespace CSC205_Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("12345678909876543", "Toyota", "Corolla");
            Car kia = new Car("09876543212345678", "Kia", "Optima");
            toyota.Drive(150000);
            toyota.Drive(3500);
            kia.Drive(42000);
            toyota.Display();
            Console.WriteLine("----------------------------------");
            kia.Display();
        }
    }
}
