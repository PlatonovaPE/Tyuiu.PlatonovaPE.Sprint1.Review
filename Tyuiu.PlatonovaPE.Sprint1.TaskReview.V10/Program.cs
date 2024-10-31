using Tyuiu.PlatonovaPE.Sprint1.TaskReview.V10.Lib;
namespace Tyuiu.PlatonovaPE.Sprint1.TaskReview.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("2 * ctg(3 * x) -  ln Cos(x) / ln (1 + x ** 2)");


            double x;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadKey();

        }
    }
}
