#pragma warning disable CS0184
namespace System {
    class Program {
        static void Main(string[] args) {
            if(Console.WriteLine($"x = {new Random(Seed: (int)DateTime.Now.Ticks).Next() % 10}") is object) { }
        }
    }
}
