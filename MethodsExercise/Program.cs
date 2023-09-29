namespace MethodsExercise
{


    public class Program
    {

        static public void greeting()
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
            Console.WriteLine($"One day, {userName} went to the zoo. He saw {userFavoriteColor}, {userFavoriteAnimal} practicing with the {userFavoriteBand}.");
        }
        static public int Sum(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++) 
            {
                sum = sum + list[i];
            }
            return sum;
        }

        static public int subtract(int x, int y)
        {
            return x - y;
        }

        static public int multiply(int x, int y)
        {
            return x * y;
        }

        static public double divide(double x, double y)
        {
            return x / y;
        }

        static public void calculater()
        {
            bool userExit = false;
            do 
            {
                Console.WriteLine("What do you want to do now? You can add, subtract, multiply or divide?");
                Console.WriteLine("To add type 1. To subtract type 2. To multiply type 3. To divide type 4. To exit type any number.");
                int userInput = int.Parse(Console.ReadLine());
                

                if (userInput == 1)
                {
                    Console.WriteLine("Give me a number for addition.");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Give me a second number for addition.");
                    int num2 = int.Parse(Console.ReadLine());

                    var result = Sum(num1, num2); 
                    Console.WriteLine($"The result is: {result}");
                     userExit = true;
                }

                else if (userInput == 2)
                {
                    Console.WriteLine("Give me a number for subtraction.");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Give me a second number for subtraction.");
                    int num2 = int.Parse(Console.ReadLine());

                    var result = subtract(num1, num2);
                    Console.WriteLine($"The result is: {result}");
                    userExit = true;
                }

                else if (userInput == 3)
                {
                    Console.WriteLine("Give me a number for multiplication.");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Give me a second number for multiplication.");
                    int num2 = int.Parse(Console.ReadLine());

                    var result = multiply(num1, num2);
                    Console.WriteLine($"The result is: {result}");
                    userExit = true;
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Give me a number for division.");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Give me a second number for division.");
                    int num2 = int.Parse(Console.ReadLine());

                    var result = divide(num1, num2);
                    Console.WriteLine($"The result is: {result}");
                    userExit = true;
                }
                else
                {
                    userExit = false;
                }
            } while (userExit);

        }

        static void Main(string[] args)
        {
            greeting();

            calculater();
        }
    }
}
