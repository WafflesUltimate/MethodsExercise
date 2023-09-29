namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, what is you name?");

            string userName = Console.ReadLine();

            Console.WriteLine($"Okay, {userName}, what is your favorite color?");

            string userFavoriteColor = Console.ReadLine();

            Console.WriteLine($"Wow {userFavoriteColor}! Now, {userName}, What is your favorite Band?");

            string userFavoriteBand = Console.ReadLine();

            Console.WriteLine($"Nice {userFavoriteBand}. Now, {userName}, What is your favorite animal?");

            string userFavoriteAnimal = Console.ReadLine();

            Console.WriteLine($"Here is a short story for you:");
            Console.WriteLine($"One day, {userName} went to the zoo. He saw {userFavoriteColor}, {userFavoriteAnimal} practicing with the {userFavoriteBand} band.");


        }
    }
}
