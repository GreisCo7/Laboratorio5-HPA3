namespace MétodosSobrecargados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (long contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine("{0}! ={1}", contador, Factorial(contador));
            }

        }

        public static long Factorial(long numero)
        {

            if (numero <= 1)
            {
                return 1;
            }

            else
            {
                return numero * Factorial(numero - 1);
            }
        }
    }
}
