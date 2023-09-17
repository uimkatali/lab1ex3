
namespace lab1ex1
{
/*    Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura
*/
    class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number % 10);
        }
    }
}