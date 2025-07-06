namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine($" Number of small carpets : ");
            int smallcarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Number of large carpets : ");
            int largecarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" price per small room :$ 25 ");
            Console.WriteLine(" price per large room :$ 35 ");

            double cost = smallcarpets * 25 + largecarpets * 35;
            double tax = cost * 0.06;
            double total = cost * tax;
            Console.WriteLine($" cost : {cost} ");
            Console.WriteLine($" tax : {tax} ");
            Console.WriteLine($" total : {total} ");

            Console.WriteLine(" this estimate is valid for30 days ");
        }
    }
}
