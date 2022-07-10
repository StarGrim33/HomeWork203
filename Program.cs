
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minDegreeOfTwo;
            int degree = 0;
            int baseNumber = 2;
            int minNumber = 1;
            int maxNumber = 1000;
            
            Random random = new Random();
            int number = random.Next(minNumber, maxNumber);

            Console.WriteLine("Случайное число равно " + number + " для нахождения минимальной степени 2, превосходящей данное число нажмите любую клавишу ");
            Console.ReadLine();

            while (Math.Pow(baseNumber, degree) <= number)
            {
                degree++;
                minDegreeOfTwo = Convert.ToInt32(Math.Pow(baseNumber, degree));
            }
            
            Console.WriteLine("Минимальная степень равна " + degree);

        }
    }
}