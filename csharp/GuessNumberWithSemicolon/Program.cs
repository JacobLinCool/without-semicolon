namespace System {
    class Program {
        public static void Main() {
            Game(new Random().Next() % 10 + 1, 0, 0);
        }
        public static void Game(int answer, int input, int count) {
            Console.WriteLine("Guess a number");
            while(int.TryParse(Console.ReadLine(), out input) && input != answer) {
                ++count;
                Console.WriteLine(input > answer ? "Too high" : "Too low");
            }
            Console.WriteLine($"You win! You guessed {count} times");
        }
    }
}
