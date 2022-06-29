// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//44 5 78 -> 78

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
            Console.WriteLine("Введите третье число: ");
            int numberC = Convert.ToInt32(Console.ReadLine());
            int max = numberA;
            if(numberB  > max) max = numberB;
            if(numberC  > max) max = numberC;
            Console.WriteLine($"Большое число:{max}");  
        }
    }
}
