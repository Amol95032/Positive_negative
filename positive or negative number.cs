namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any Number");
            num=Convert.ToInt32(Console.ReadLine());
            if(num>=0)
            {
                Console.WriteLine("number is positive"+ num);
            }
            else
            {
                Console.WriteLine("number is negative"+ num);
            }
        }
    }
}