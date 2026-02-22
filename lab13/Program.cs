//Даны два предложения. Для каждого слова первого предложения определить, входит ли оно во второе предложение.
//Повторяющиеся слова первого предложения не рассматривать.

namespace lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое предложение: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("введите второе предложение: ");
            string s2 = Console.ReadLine();
        
            string[] words1 = s1.Split(' ');
            string[] words2 = s2.Split(' ');

            Console.WriteLine(string.Join(", ", words1));
            Console.WriteLine(string.Join(", ", words2));
        }
    }
}
