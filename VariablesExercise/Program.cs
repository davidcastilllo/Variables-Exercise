namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "David";
            string lastName = "Castillo";
            int age = 22;
            char middleInitial = 'S';
            bool isAwesome = true;
            double pi = 3.14159;
            decimal piButDecimal = 3.14159m;

            Console.WriteLine($"Hello my name is {name} {middleInitial} {lastName} and I am {age} years old. It is {isAwesome} I am awesome because I know Pi ({pi}) off the top of my head.");

        }
    }
}
