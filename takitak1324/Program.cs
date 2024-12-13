
namespace takitak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tingimuslaused IF...ELSE";
            Console.WriteLine("\tTingimuslaused IF...ELSE\n\n");
            Console.WriteLine("\tMis pilet sulle sobib\n\n");
            Console.WriteLine("Sisesta inimese vanus (täisarv) -");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))

                if (age < 0)
                {
                    Console.WriteLine("Vanus ei saa olla negatiivne.");
                }
                else if (age <= 12)
                {
                    Console.WriteLine("Laste pilet.");
                }
                else if (age <= 65)
                {
                    Console.WriteLine("Täispilet.");
                }
                else
                {
                    Console.WriteLine("Pensionäri pilet.");
                }
            else
            {
                Console.WriteLine("Palun sisesta õige täisarv.");
            }
        }
    }
}
