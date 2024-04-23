namespace fibo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1,c,sayac=1;
            string write = "";
            Console.WriteLine("Desired Fibonacci number?:");
            int DesiredFibo=int.Parse(Console.ReadLine());
            while(true)
            {
                c = a + b;
                a = b; 
                b=c;
                if (DesiredFibo==sayac)
                {
                    write = DesiredFibo+". Fibonacci number:" + a;
                    break;
                }
                sayac++;
            }
            Console.WriteLine(write );
        } 
    }
}
