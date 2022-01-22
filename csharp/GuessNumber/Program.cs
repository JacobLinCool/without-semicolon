#pragma warning disable CS0184
namespace System {
    public class Program {
        public static void Main() {
            if(Game(new Random().Next() % 10 + 1, 0, 0) is object) { }
        }
        public static void Game(int answer, int input, int count) {
            while(!(Console.WriteLine("Guess a number") is object)
                && (++count > 0)
                && int.TryParse(Console.ReadLine(), out input)
                && input != answer
                && !(Console.WriteLine(input > answer ? "Too high" : "Too low") is object)
            ) { }
            if(Console.WriteLine($"You win! You guessed {count} times") is object) { }
        }
    }
}
