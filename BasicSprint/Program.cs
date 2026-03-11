namespace BasicSprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            bool isLearningCSharpFun = true;
            string favouriteFilm = "Avatar";
            favouriteFilm = "High School Musical";
            string firstName = "Yosef";
            printGreeting(firstName);
        }

        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, Good Morning " + name);
        }

    }
}
