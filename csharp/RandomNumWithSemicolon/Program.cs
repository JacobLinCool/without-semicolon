namespace System {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"x = {new Random(Seed: (int)DateTime.Now.Ticks).Next() % 10}");
        }
    }
}
