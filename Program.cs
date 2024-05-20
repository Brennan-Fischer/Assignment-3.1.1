using System.Text;

namespace Assignment_3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following is a string of even number from 0 to 98");
            string returnEven = ReturnEvenNumbers();

            string ReturnEvenNumbers()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 2; i < 100; i=i+2)
                {
                    sb.Append(Convert.ToString(i+ " ")); 
                }
                Console.WriteLine(sb.ToString());
                return sb.ToString();
            }
        }
    }
}
