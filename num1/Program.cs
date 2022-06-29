//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            if(numberA < numberB ) 
            {
                Console.WriteLine($"Большое число:{numberB}");
                Console.WriteLine($"Меньшее число:{numberA}");
            }
            else
            {
                Console.WriteLine($"Большое число:{numberA}");
                Console.WriteLine($"Меньшее число:{numberB}");
            }
            if (numberA == numberB)
            {
                Console.WriteLine($"Они равны");
            }   
        }
    }
}
