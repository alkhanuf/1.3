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

            string[] res = Logic.FindWords(s1, s2);

            Console.WriteLine(string.Join(", ", res));
        }
    }
}